DROP VIEW Poslovni_partner_v CASCADE;

DROP VIEW Proizvodi_v CASCADE;

DROP VIEW Skladiste_v CASCADE;

DROP VIEW Zaposlenik_v CASCADE;

DROP VIEW Narudzba_v CASCADE;

DROP TABLE kontakt CASCADE;

DROP TABLE poslovni_partner CASCADE;

DROP TABLE poslovni_partner_kontakt CASCADE;

DROP TABLE proizvodi CASCADE;

DROP TABLE proizvodi_sastojci CASCADE;

DROP TABLE sastojci CASCADE;

DROP TABLE skladiste CASCADE;

DROP TABLE vrsta_kontakta CASCADE;

DROP TABLE vrsta_poslovnog_partnera CASCADE;

DROP TABLE vrsta_proizvoda CASCADE;

DROP TABLE vrsta_zaposlenika CASCADE;

DROP TABLE zaposlenik CASCADE;

DROP TABLE zaposlenik_kontakt CASCADE;

DROP TABLE narudzba CASCADE;

DROP TABLE racun CASCADE;

DROP FUNCTION auto_narudzba_racun CASCADE;

DROP FUNCTION provjera_kolicine_minimalno CASCADE;

DROP FUNCTION provjera_kolicine_maksimalno CASCADE;

CREATE TABLE kontakt (
    id                SERIAL PRIMARY KEY,
    vrsta_kontakta_id int NOT NULL,
    vrijednost        varchar(255)
);

CREATE TABLE poslovni_partner (
    id                          SERIAL PRIMARY KEY,
    vrsta_poslovnog_partnera_id int NOT NULL,
    naziv                       varchar(255),
    oib                         varchar(20),
    adresa                      varchar(255)
);

CREATE TABLE poslovni_partner_kontakt (
    id                  SERIAL PRIMARY KEY,
    poslovni_partner_id int NOT NULL,
    kontakt_id          int NOT NULL
);

CREATE TABLE proizvodi (
    id                 SERIAL PRIMARY KEY,
    naziv_proizvoda    varchar(255),
    vrsta_proizvoda_id int NOT NULL,
    cijena             decimal NOT NULL
);

CREATE TABLE proizvodi_sastojci (
    id          SERIAL PRIMARY KEY,
    proizvodi_id int NOT NULL,
    sastojci_id  int NOT NULL,
    količina     decimal NOT NULL
);

CREATE TABLE sastojci (
    id              SERIAL PRIMARY KEY,
    naziv           varchar(255) NOT NULL,
    mjerna_jedinica varchar(255) NOT NULL,
    cijena          decimal
);

CREATE TABLE skladiste (
    id           SERIAL PRIMARY KEY,
    kolicina     decimal,
    rok_trajanja DATE,
    proizvod_id  int,
    sastojci_id  int
);

CREATE TABLE vrsta_kontakta (
    id    SERIAL PRIMARY KEY,
    naziv varchar(255)
);

CREATE TABLE vrsta_poslovnog_partnera (
    id    SERIAL PRIMARY KEY,
    naziv varchar(255)
);

CREATE TABLE vrsta_proizvoda (
    id    SERIAL PRIMARY KEY
        CONSTRAINT vrsta_proizvoda_id NOT NULL,
    naziv varchar(255)
);

CREATE TABLE vrsta_zaposlenika (
    id    SERIAL PRIMARY KEY,
    naziv varchar(255)
);

CREATE TABLE zaposlenik (
    id                  SERIAL PRIMARY KEY,
    ime                 varchar(255),
    prezime             varchar(255),
    oib                 varchar(20),
    vrsta_zaposlenja_id int NOT NULL,
    datum_zaposlenja    DATE
);

CREATE TABLE zaposlenik_kontakt (
    id            SERIAL PRIMARY KEY,
    zaposlenik_id int NOT NULL,
    kontakt_id    int NOT NULL
);

CREATE TABLE narudzba (
    id                  SERIAL PRIMARY KEY,
    datum_narudzbe      DATE,
    zaposlenik_id       int NOT NULL,
    poslovni_partner_id int,
    sastojak_id         int NOT NULL,
    kolicina            int NOT NULL
);

CREATE TABLE racun (
    id                  SERIAL PRIMARY KEY,
    datum_racuna        DATE,
    zaposlenik_id       int NOT NULL,
    poslovni_partner_id int,
    proizvod_id         int NOT NULL,
    kolicina            int NOT NULL
);

ALTER TABLE proizvodi
    ADD CONSTRAINT kata_pro_vrs_pro_fk FOREIGN KEY ( vrsta_proizvoda_id )
        REFERENCES vrsta_proizvoda ( id );

ALTER TABLE kontakt
    ADD CONSTRAINT kontakt_vrsta_kontakta_fk FOREIGN KEY ( vrsta_kontakta_id )
        REFERENCES vrsta_kontakta ( id );

ALTER TABLE poslovni_partner_kontakt
    ADD CONSTRAINT pos_par_kon_kon_fk FOREIGN KEY ( kontakt_id )
        REFERENCES kontakt ( id );

ALTER TABLE poslovni_partner_kontakt
    ADD CONSTRAINT p_p_kon_p_p_fk FOREIGN KEY ( poslovni_partner_id )
        REFERENCES poslovni_partner ( id );

ALTER TABLE poslovni_partner
    ADD CONSTRAINT p_p_v_p_p_fk FOREIGN KEY ( vrsta_poslovnog_partnera_id )
        REFERENCES vrsta_poslovnog_partnera ( id );

ALTER TABLE proizvodi_sastojci
    ADD CONSTRAINT s_kat_pro_fk FOREIGN KEY ( proizvodi_id )
        REFERENCES proizvodi ( id );

ALTER TABLE proizvodi_sastojci
    ADD CONSTRAINT pro_sastojci_fk FOREIGN KEY ( sastojci_id )
        REFERENCES sastojci ( id );

ALTER TABLE skladiste
    ADD CONSTRAINT s_katalog_proizvoda_fk FOREIGN KEY ( proizvod_id )
        REFERENCES proizvodi ( id );

ALTER TABLE skladiste
    ADD CONSTRAINT s_sastojci_fk FOREIGN KEY ( sastojci_id )
        REFERENCES sastojci ( id );

ALTER TABLE zaposlenik_kontakt
    ADD CONSTRAINT table_3_zaposlenik_fk FOREIGN KEY ( zaposlenik_id )
        REFERENCES zaposlenik ( id );

ALTER TABLE zaposlenik_kontakt
    ADD CONSTRAINT zaposlenik_kontakt_kontakt_fk FOREIGN KEY ( kontakt_id )
        REFERENCES kontakt ( id );

ALTER TABLE zaposlenik
    ADD CONSTRAINT z_v_z_fk FOREIGN KEY ( vrsta_zaposlenja_id )
        REFERENCES vrsta_zaposlenika ( id );

ALTER TABLE racun
    ADD CONSTRAINT racun_zaposlenik_fk FOREIGN KEY ( zaposlenik_id )
        REFERENCES zaposlenik ( id );

ALTER TABLE racun
    ADD CONSTRAINT racun_pp_fk FOREIGN KEY ( poslovni_partner_id )
        REFERENCES poslovni_partner ( id );

ALTER TABLE racun
    ADD CONSTRAINT racun_proizvod_fk FOREIGN KEY ( proizvod_id )
        REFERENCES proizvodi ( id );

ALTER TABLE narudzba
    ADD CONSTRAINT narudzba_zaposlenik_fk FOREIGN KEY ( zaposlenik_id )
        REFERENCES zaposlenik ( id );

ALTER TABLE narudzba
    ADD CONSTRAINT narudzba_pp_fk FOREIGN KEY ( poslovni_partner_id )
        REFERENCES poslovni_partner ( id );

ALTER TABLE narudzba
    ADD CONSTRAINT narudzba_proizvod_fk FOREIGN KEY ( sastojak_id )
        REFERENCES sastojci ( id );

CREATE OR REPLACE VIEW Poslovni_partner_v (id, naziv, oib, adresa, vrsta_poslovnog_partnera, vrsta_kontakta, kontakt) AS
SELECT
    poslovni_partner.id,
    poslovni_partner.naziv,
    poslovni_partner.oib,
    poslovni_partner.adresa,
    vrsta_poslovnog_partnera.naziv AS vrsta_poslovnog_partnera,
    vrsta_kontakta.naziv           AS vrsta_kontakta,
    (select array_to_string(array_agg(vrsta_kontakta.naziv || ': ' || kontakt.vrijednost), ',') from kontakt INNER JOIN vrsta_kontakta ON vrsta_kontakta.id = kontakt.vrsta_kontakta_id join poslovni_partner_kontakt on poslovni_partner.id = poslovni_partner_kontakt.poslovni_partner_id and poslovni_partner_kontakt.kontakt_id = kontakt.id) as kontakt
FROM
         poslovni_partner
    INNER JOIN vrsta_poslovnog_partnera ON vrsta_poslovnog_partnera.id = poslovni_partner.vrsta_poslovnog_partnera_id
    LEFT JOIN poslovni_partner_kontakt ON poslovni_partner.id = poslovni_partner_kontakt.poslovni_partner_id
    LEFT JOIN kontakt ON kontakt.id = poslovni_partner_kontakt.kontakt_id
    LEFT JOIN vrsta_kontakta ON vrsta_kontakta.id = kontakt.vrsta_kontakta_id
;


CREATE OR REPLACE VIEW Proizvodi_v ( id, naziv_proizvoda, cijena, naziv, sastojci) AS
    SELECT
        proizvodi.id,
        proizvodi.naziv_proizvoda,
        proizvodi.cijena,
        vrsta_proizvoda.naziv as vrsta_proizvoda,
        (select array_to_string(array_agg(sastojci.naziv || ' ' || proizvodi_sastojci.količina || ' ' || sastojci.mjerna_jedinica), ',') from proizvodi_sastojci INNER JOIN sastojci ON sastojci.id = proizvodi_sastojci.sastojci_id  where proizvodi.id = proizvodi_sastojci.proizvodi_id) as sastojci
    FROM 
             proizvodi
        INNER JOIN vrsta_proizvoda ON vrsta_proizvoda.id = proizvodi.vrsta_proizvoda_id;

		 
CREATE OR REPLACE VIEW Skladiste_v (id, kolicina, rok_trajanja, roba ) AS
SELECT
    skladiste.id,
    skladiste.kolicina,
    skladiste.rok_trajanja,
    case 
        when proizvodi.id is not null then proizvodi.naziv_proizvoda
        else sastojci.naziv
    end as roba
FROM
         skladiste
    left JOIN proizvodi ON proizvodi.id = skladiste.proizvod_id
    left JOIN sastojci ON sastojci.id = skladiste.sastojci_id;

CREATE OR REPLACE VIEW Zaposlenik_v ( id, ime, prezime, oib, datum_zaposlenja, naziv, kontakt) as
SELECT
    zaposlenik.id,
    zaposlenik.ime,
    zaposlenik.prezime,
    zaposlenik.oib,
    zaposlenik.datum_zaposlenja,
    vrsta_zaposlenika.naziv,
    (select array_to_string(array_agg(vrsta_kontakta.naziv || ': ' || kontakt.vrijednost), ',') from kontakt INNER JOIN vrsta_kontakta ON vrsta_kontakta.id = kontakt.vrsta_kontakta_id join zaposlenik_kontakt on zaposlenik.id = zaposlenik_kontakt.zaposlenik_id and zaposlenik_kontakt.kontakt_id = kontakt.id) as kontakt
FROM
         zaposlenik
    INNER JOIN vrsta_zaposlenika ON vrsta_zaposlenika.id = zaposlenik.vrsta_zaposlenja_id;

CREATE OR REPLACE VIEW Narudzba_v (datum_narudzbe, sastojak, kolicina, mjerna_jedinica, cijena, cijena_ukupno, kreirao, poslovni_partner, oib) as
SELECT
    narudzba.datum_narudzbe,
    sastojci.naziv AS sastojak,
    narudzba.kolicina,
    sastojci.mjerna_jedinica,
    sastojci.cijena,
    narudzba.kolicina * sastojci.cijena as cijena_ukupno,
    zaposlenik.ime || ' ' || zaposlenik.prezime as kreirao,
    poslovni_partner.naziv as poslovni_partner,
    poslovni_partner.oib
FROM
    narudzba
    INNER JOIN zaposlenik ON zaposlenik.id = narudzba.zaposlenik_id
    INNER JOIN vrsta_zaposlenika ON vrsta_zaposlenika.id = zaposlenik.vrsta_zaposlenja_id
    INNER JOIN poslovni_partner ON poslovni_partner.id = narudzba.poslovni_partner_id
    INNER JOIN vrsta_poslovnog_partnera ON vrsta_poslovnog_partnera.id = poslovni_partner.vrsta_poslovnog_partnera_id
    INNER JOIN sastojci ON sastojci.id = narudzba.sastojak_id;


insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (1, 'Šećer', 'kg', 5);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (2, 'Voda', 'L', 2);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (3, 'Mlijeko', 'L', 5);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (4, 'Čokolada', 'g', 10);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (5, 'Orasi', 'kg', 100);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (6, 'Kava', 'kg', 100);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (7, 'Jabuka', 'kg', 20);
insert into sastojci (id, naziv, mjerna_jedinica, cijena) values (8, 'Jagoda', 'kg', 40);

insert into vrsta_proizvoda (id, naziv) values (1, 'Kava');
insert into vrsta_proizvoda (id, naziv) values (2, 'Torta');
insert into vrsta_proizvoda (id, naziv) values (3, 'Kolač');
insert into vrsta_proizvoda (id, naziv) values (4, 'Sladoled');

insert into proizvodi (id, naziv_proizvoda, vrsta_proizvoda_id, cijena) values (1, 'Kava s mlijekom', 1, 10);
insert into proizvodi (id, naziv_proizvoda, vrsta_proizvoda_id, cijena) values (2, 'Skradinska torta', 2, 50);
insert into proizvodi (id, naziv_proizvoda, vrsta_proizvoda_id, cijena) values (3, 'Medena pita', 3, 25);
insert into proizvodi (id, naziv_proizvoda, vrsta_proizvoda_id, cijena) values (4, 'Kuglica jagode', 4, 5);

insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (1, 1, 6, 0.1);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (2, 1, 3, 0.1);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (3, 2, 1, 0.1);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (4, 2, 4, 100);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (5, 2, 5, 1);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (6, 3, 1, 0.5);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (7, 3, 7, 1);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (8, 4, 8, 0.1);
insert into proizvodi_sastojci (id, proizvodi_id, sastojci_id, količina) values (9, 4, 2, 0.5);

insert into vrsta_zaposlenika (id, naziv) values (1, 'Slastičar');
insert into vrsta_zaposlenika (id, naziv) values (2, 'Konobar');

insert into zaposlenik (id, ime, prezime, oib, vrsta_zaposlenja_id, datum_zaposlenja) values (1, 'Ivo', 'Ivić', '54684546', 1, CURRENT_DATE);
insert into zaposlenik (id, ime, prezime, oib, vrsta_zaposlenja_id, datum_zaposlenja) values (2, 'Pero', 'Perić', '1234567', 2, CURRENT_DATE);
insert into zaposlenik (id, ime, prezime, oib, vrsta_zaposlenja_id, datum_zaposlenja) values (3, 'Miro', 'Mirić', '4567891', 1, CURRENT_DATE);
insert into zaposlenik (id, ime, prezime, oib, vrsta_zaposlenja_id, datum_zaposlenja) values (4, 'Ante', 'Antić', '7654321', 2, CURRENT_DATE);

insert into vrsta_poslovnog_partnera (id, naziv) values (1, 'Dobavljač');
insert into vrsta_poslovnog_partnera (id, naziv) values (2, 'Kupac');

insert into poslovni_partner (id, vrsta_poslovnog_partnera_id, naziv, oib, adresa) values (1, 1, 'Jabuka d.o.o.', '065465465', 'Nove Plavnice 14');
insert into poslovni_partner (id, vrsta_poslovnog_partnera_id, naziv, oib, adresa) values (2, 1, 'Studenac', '456712353', 'Pavle Miškina 23');
insert into poslovni_partner (id, vrsta_poslovnog_partnera_id, naziv, oib, adresa) values (3, 2, 'Hotel Bjelovar', '151548563', 'Stare Plavnice 34');
insert into poslovni_partner (id, vrsta_poslovnog_partnera_id, naziv, oib, adresa) values (4, 2, 'Terme Tuhelj', '784518941', 'Hrgovljani 8');

insert into vrsta_kontakta (id, naziv) values (1, 'Telefon');
insert into vrsta_kontakta (id, naziv) values (2, 'E-mail');

insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (1, 2, 'ivo.ivica@slasticarna.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (2, 1, '2654658');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (3, 2, 'ivo.mail2@slasticarna.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (4, 2, 'pero.mail@slasticarna.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (5, 2, 'miro.mail@slasticarna.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (6, 2, 'ante.mail@slasticarna.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (7, 1, '1545748');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (8, 1, '2744451');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (9, 1, '4541848');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (10, 2, 'jabuka@jabuka.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (11, 2, 'studenac@studenac.hr');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (12, 1, '6546484');
insert into kontakt (id, vrsta_kontakta_id, vrijednost) values (13, 1, '7484584');

insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (1, 1, 1);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (2, 1, 3);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (3, 1, 9);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (4, 2, 2);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (5, 2, 4);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (6, 3, 5);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (7, 4, 6);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (8, 3, 7);
insert into zaposlenik_kontakt (id, zaposlenik_id, kontakt_id) values (9, 4, 8);

insert into poslovni_partner_kontakt (id, poslovni_partner_id, kontakt_id) values (1, 1, 10);
insert into poslovni_partner_kontakt (id, poslovni_partner_id, kontakt_id) values (2, 2, 11);
insert into poslovni_partner_kontakt (id, poslovni_partner_id, kontakt_id) values (3, 3, 12);
insert into poslovni_partner_kontakt (id, poslovni_partner_id, kontakt_id) values (4, 4, 13);

insert into skladiste (id, kolicina, rok_trajanja, proizvod_id, sastojci_id) values (1, 10, CURRENT_DATE + 100, 2, null);
insert into skladiste (id, kolicina, rok_trajanja, proizvod_id, sastojci_id) values (2, 20, CURRENT_DATE + 100, null, 4);
insert into skladiste (id, kolicina, rok_trajanja, proizvod_id, sastojci_id) values (3, 30, CURRENT_DATE + 100, 3, null);
insert into skladiste (id, kolicina, rok_trajanja, proizvod_id, sastojci_id) values (4, 40, CURRENT_DATE + 100, null, 5);

CREATE FUNCTION public."auto_narudzba_racun"()
RETURNS TRIGGER
LANGUAGE plpgsql
COST 100
VOLATILE
AS
$$
DECLARE
	l_poslovni_partner_id 	poslovni_partner.id%TYPE;
	l_poslovni_partner2_id  poslovni_partner.id%TYPE;
	l_zaposlenik_id 		zaposlenik.id%TYPE;
BEGIN

    select id into l_zaposlenik_id from zaposlenik ORDER BY random() limit 1;

    select id into l_poslovni_partner_id from poslovni_partner WHERE poslovni_partner.vrsta_poslovnog_partnera_id = 1  ORDER BY random() limit 1;
	select id into l_poslovni_partner2_id from poslovni_partner WHERE poslovni_partner.vrsta_poslovnog_partnera_id = 2  ORDER BY random() limit 1;

   if (new.sastojci_id is not null) then 
    if (new.kolicina > old.kolicina) then
        insert into narudzba (datum_narudzbe, zaposlenik_id, poslovni_partner_id, sastojak_id, kolicina) values (CURRENT_DATE, l_zaposlenik_id, l_poslovni_partner_id, new.sastojci_id, new.kolicina - old.kolicina);
    end if;    
   end if;
    
  if (new.proizvod_id is not null) then     
    if (new.kolicina < old.kolicina) then
        insert into racun (datum_racuna, zaposlenik_id, poslovni_partner_id, proizvod_id, kolicina) values (CURRENT_DATE, l_zaposlenik_id, l_poslovni_partner2_id, new.proizvod_id, old.kolicina - new.kolicina);
    end if;    
   end if;
	RETURN NEW;

END;
$$;
CREATE TRIGGER auto_narudzba_racun
BEFORE UPDATE on Skladiste
FOR EACH ROW EXECUTE PROCEDURE public."auto_narudzba_racun"()
;
CREATE FUNCTION public."provjera_kolicine_minimalno"()
RETURNS TRIGGER
LANGUAGE plpgsql
COST 100
VOLATILE
AS
$$
BEGIN
	IF new.Kolicina < 0 THEN
	RAISE EXCEPTION 'Nije dostupno uklanjanje željene količine. Trenutno dostupna količina: %', old.Kolicina;
	END IF;
    RETURN NEW;
END;
$$;
CREATE TRIGGER provjera_kolicine_minimalno
BEFORE INSERT OR UPDATE on Skladiste
FOR EACH ROW EXECUTE PROCEDURE public."provjera_kolicine_minimalno"()
;
CREATE FUNCTION public."provjera_kolicine_maksimalno"()
RETURNS TRIGGER
LANGUAGE plpgsql
COST 100
VOLATILE
AS
$$
BEGIN
	IF NEW.Kolicina > 100 THEN
	RAISE EXCEPTION 'Nije dostupno dodavanje željene količine, maksimalna količina je 100. Trenutno dostupna količina: %', OLD.Kolicina;
	END IF;
    RETURN NEW;
END;
$$;
CREATE TRIGGER provjera_kolicine_maksimalno
BEFORE INSERT OR UPDATE on Skladiste
FOR EACH ROW EXECUTE PROCEDURE public."provjera_kolicine_maksimalno"()