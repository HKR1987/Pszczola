using System;
using System.Collections.Generic;
using System.Data;

namespace Pszczola.Model
{
    class Zapytania
    {
        private List<Miodobranie> _listaMiodobran;
        private DataSet _ds;
        private Polaczenie _polaczenie = new Polaczenie();
        private HistUl _hist;
        private Ul _ul;
        private Notatka _notatka;
        List<Ul> _listaUli;
        List<Notatka> _listaNotatek;
        private Miodobranie _miodobranie;

        public List<HistUl> PobierzHistorie(int ulId, int rok)
        {
            _ds = _polaczenie.ZapytanieDataSet($"SELECT id, gdzie, zmianaz, zmianana, data FROM historia where idul={ulId} and rok={rok}");
            List<HistUl> listHist = new List<HistUl>();
            foreach (DataRow row in _ds.Tables[0].Rows)
            {
                _hist = new HistUl
                {
                    Id = Int32.Parse(row["id"].ToString()),
                    IdUla = ulId,
                    Rok = rok,
                    Gdzie = row["gdzie"].ToString(),
                    ZmianaZ = row["zmianaz"].ToString(),
                    ZmianaNa = row["zmianana"].ToString(),
                    Czas = row["data"].ToString()
                };
                listHist.Add(_hist);
            }
            return listHist;
        }

        public Ul PobierzUl(int ulId)
        {
            _ds = _polaczenie.ZapytanieDataSet($"SELECT id, nazwa, pochodzeniem, oznaczeniem FROM Ul where id={ulId}");
            foreach (DataRow row in _ds.Tables[0].Rows)
            {
                _ul = new Ul
                {
                    IdUla = Int32.Parse(row["id"].ToString()),
                    Nazwa = row["nazwa"].ToString(),
                    PochodzenieMatki = row["pochodzeniem"].ToString(),
                    OznaczenieMatki = row["oznaczeniem"].ToString(),
                };
            }
            return _ul;
        }

        public List<Ul> PobierzListeUli(string rok)
        {
            _listaUli = new List<Ul>();
            _ds = _polaczenie.ZapytanieDataSet("SELECT id, nazwa FROM Ul");
            foreach (DataRow row in _ds.Tables[0].Rows)
            {
                _ul = new Ul
                {
                    IdUla = Int32.Parse(row["id"].ToString()),
                    Nazwa = row["nazwa"].ToString()
                };
                _listaUli.Add(_ul);
            }
            return _listaUli;
        }

        public List<Notatka> PobierzNotatki(int idUla, int rok)
        {
            _listaNotatek = new List<Notatka>();
            _ds = _polaczenie.ZapytanieDataSet($"SELECT opis, data FROM notatki where idul={idUla} and rok={rok} ORDER BY data DESC");
            foreach (DataRow row in _ds.Tables[0].Rows)
            {
                _notatka = new Notatka
                {
                    Opis = row["opis"].ToString(),
                    DataCzas = row["data"].ToString()
                };
                _listaNotatek.Add(_notatka);
            }
            return _listaNotatek;
        }

        public List<Miodobranie> PobierzMiodobrania(int idUla, int rok)
        {
            _listaMiodobran = new List<Miodobranie>();
            _ds = _polaczenie.ZapytanieDataSet($"SELECT idul, rok, data, ramki, wagan, wagab, uwagi FROM miodobrania where idul={idUla} and rok={rok} ORDER BY data DESC");
            foreach (DataRow row in _ds.Tables[0].Rows)
            {
                _miodobranie = new Miodobranie
                {       
                    IdUl = Int32.Parse(row["idul"].ToString()),
                    Rok = Int32.Parse(row["rok"].ToString()),
                    Data = row["data"].ToString(),
                    Ramki = Int32.Parse(row["ramki"].ToString()),
                    WagaNetto = Double.Parse(row["wagan"].ToString()),
                    WagaBrutto = Double.Parse(row["wagab"].ToString()),
                    Uwagi = row["uwagi"].ToString(),

                };
                _listaNotatek.Add(_notatka);
            }
            return _listaMiodobran;
        }

        public void DodajUl(string nazwa, string rok)
        {
            _polaczenie.ZapytanieVoid($"insert into Ul (nazwa) values ('{nazwa}')");
        }

        public void AktualizujUl(Ul ul)
        {
            _polaczenie.ZapytanieDataSet($"UPDATE UL SET nazwa = '{ul.Nazwa}', pochodzeniem = '{ul.PochodzenieMatki}', oznaczeniem = '{ul.OznaczenieMatki}' WHERE ID={ul.IdUla}");
        }

        public void DodajHistorie(string gdzie, int id, string zmz, string zmna, int rok)
        {
            _polaczenie.ZapytanieVoid($"insert into historia (gdzie, idul, zmianaz, zmianana, rok) values ('{gdzie}', {id}, '{zmz}', '{zmna}', {rok})");
        }

        public void UtworzTabele()
        {
            _polaczenie.ZapytanieVoid("create table if not exists Ul (id integer PRIMARY KEY AUTOINCREMENT, nazwa VARCHAR(255) NOT NULL, pochodzeniem VARCHAR(255), oznaczeniem VARCHAR(255))");
            _polaczenie.ZapytanieVoid("create table if not exists historia (id integer PRIMARY KEY AUTOINCREMENT, idul integer, gdzie VARCHAR(255), zmianaz VARCHAR(255), zmianana VARCHAR(255), rok integer, data TIMESTAMP DEFAULT (datetime('now','localtime')))");
            _polaczenie.ZapytanieVoid("create table if not exists notatki (id integer PRIMARY KEY AUTOINCREMENT, idul integer, opis VARCHAR(255), rok integer, data TIMESTAMP DEFAULT (datetime('now','localtime')))");
            _polaczenie.ZapytanieVoid("create table if not exists miodobrania (id integer PRIMARY KEY AUTOINCREMENT, idul integer, rok integer, data VARCHAR(255), ramki integer, wagan DOUBLE DEFAULT 0, wagab DOUBLE DEFAULT 0, uwagi VARCHAR(255))");
        }

        internal void DodajNotatke(string tresc, int idUla, int rok)
        {
            _polaczenie.ZapytanieDataSet($"INSERT INTO notatki (opis, idul, rok) VALUES ('{tresc}',{idUla},{rok})");
        }

        internal void DodajMiodobranie(Miodobranie m)
        {
            _polaczenie.ZapytanieDataSet($"INSERT INTO miodobrania (idul, rok, data, ramki, wagan, wagab, uwagi) VALUES ({m.IdUl}, {m.Rok}, '{m.Data}', {m.Ramki}, {m.WagaNetto.ToString().Replace(',', '.')}, {m.WagaBrutto.ToString().Replace(',', '.')}, '{m.Uwagi}')");
        }
    }
}
