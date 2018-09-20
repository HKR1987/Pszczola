using System;
using System.Collections.Generic;
using System.Data;

namespace Pszczola.Model
{
    class Zapytania
    {
        private DataSet _ds;
        private Polaczenie _polaczenie = new Polaczenie();
        private HistUl _hist;
        private Ul _ul;

        public List<HistUl> PobierzHistorie(int ulId, int rok)
        {
            _ds = _polaczenie.ZapytanieDataSet($"SELECT id, gdzie, zmianaz, zmianana, data FROM historia where idul={ulId} and rok={rok}");
            List<HistUl> listHist = new List<HistUl>();
            foreach (DataRow s in _ds.Tables[0].Rows)
            {
                _hist = new HistUl
                {
                    Id = Int32.Parse(s["id"].ToString()),
                    IdUla = ulId,
                    Rok = rok,
                    Gdzie = s["gdzie"].ToString(),
                    ZmianaZ = s["zmianaz"].ToString(),
                    ZmianaNa = s["zmianana"].ToString(),
                    Czas = s["data"].ToString()
                };
                listHist.Add(_hist);
            }
            return listHist;
        }

        public Ul PobierzUl(int ulId)
        {
            _ds = _polaczenie.ZapytanieDataSet($"SELECT id, nazwa, pochodzeniem, oznaczeniem FROM Ul where id={ulId}");
            foreach (DataRow s in _ds.Tables[0].Rows)
            {
                _ul = new Ul
                {
                    IdUla = Int32.Parse(s["id"].ToString()),
                    Nazwa = s["nazwa"].ToString(),
                    PochodzenieMatki = s["pochodzeniem"].ToString(),
                    OznaczenieMatki = s["oznaczeniem"].ToString(),
                };
            }
            return _ul;
        }

        public DataSet PobierzListeUli(string rok)
        {
           return _polaczenie.ZapytanieDataSet("SELECT id, nazwa FROM Ul");
        }

        public DataSet PobierzNotatki(int idUla, int rok)
        {
            return _polaczenie.ZapytanieDataSet($"SELECT opis, data FROM notatki where idul={idUla} and rok={rok} ORDER BY data DESC LIMIT 5");
        }

        public DataSet PobierzMiodobrania(int idUla, int rok)
        {
            return _polaczenie.ZapytanieDataSet($"SELECT idul, rok, data, ramki, wagan, wagab, uwagi FROM miodobrania where idul={idUla} and rok={rok} ORDER BY data DESC");
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
