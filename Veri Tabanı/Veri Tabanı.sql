CREATE DATABASE KutuphaneOtomasyonu

use KutuphaneOtomasyonu

CREATE TABLE admin (
    adminID INT PRIMARY KEY IDENTITY(1,1),
    ad NVARCHAR(45) NOT NULL,
    soyad NVARCHAR(45) NOT NULL,
    eMail NVARCHAR(100) NOT NULL UNIQUE,
    sifre NVARCHAR(45) NOT NULL DEFAULT '123',
    telefon NVARCHAR(45),
    adres NVARCHAR(45)
);



CREATE TABLE uye (
    uyeID INT PRIMARY KEY IDENTITY(1,1),
    ad NVARCHAR(45) NOT NULL,
    soyad NVARCHAR(45) NOT NULL,
    eMail NVARCHAR(100) NOT NULL UNIQUE,
    sifre NVARCHAR(45) NOT NULL DEFAULT '123',
    telefon NVARCHAR(45),
    adres NVARCHAR(45),
    uyelikDurumu INT DEFAULT 1
);

ALTER TABLE admin ADD normalizedEmail NVARCHAR(255);
ALTER TABLE uye ADD normalizedEmail NVARCHAR(255);


CREATE TABLE kitap (
    kitapID INT PRIMARY KEY IDENTITY(1,1),
    ISBN VARCHAR(13) NOT NULL UNIQUE,
    ad NVARCHAR(45) NOT NULL,
    yazar NVARCHAR(45) NOT NULL,
    baskiYili VARCHAR(45),
    yayinEvi NVARCHAR(45),
    sayfaSayisi VARCHAR(45),
    aciklama NVARCHAR(MAX),
    kitapDurumu TINYINT NOT NULL DEFAULT 1,
    adminID INT,
    islemSayisi INT DEFAULT 0,
    CONSTRAINT fk_kitap_adminID FOREIGN KEY (adminID) REFERENCES admin (adminID)
);



CREATE TABLE kategori (
    kategoriID INT PRIMARY KEY IDENTITY(1,1),
    kategoriAdi NVARCHAR(45) NOT NULL UNIQUE
);


CREATE TABLE kitap_kategori (
    kitapID INT NOT NULL,
    kategoriID INT NOT NULL,
    PRIMARY KEY (kitapID, kategoriID),
    CONSTRAINT FK_kategori FOREIGN KEY (kategoriID) REFERENCES kategori (kategoriID),
    CONSTRAINT FK_kitap FOREIGN KEY (kitapID) REFERENCES kitap (kitapID)
);

CREATE TABLE islem (
    islemID INT NOT NULL IDENTITY(1,1),
    uyeID INT NOT NULL,
    kitapID INT NOT NULL,
    islemTarihi DATE,
    iadeTarihi DATE,
    islemDurumu INT NOT NULL DEFAULT 0,
    adminID INT,
    emanetDurumu NVARCHAR(45) DEFAULT 'RAFTA',
    PRIMARY KEY (islemID, uyeID, kitapID),
    CONSTRAINT fk_kitapID FOREIGN KEY (kitapID) REFERENCES kitap (kitapID),
    CONSTRAINT fk_uyeID FOREIGN KEY (uyeID) REFERENCES uye (uyeID),
    CONSTRAINT fk_admin FOREIGN KEY (adminID) REFERENCES admin (adminID)
);

ALTER TABLE islem DROP CONSTRAINT fk_admin;

ALTER TABLE islem ADD CONSTRAINT fk_admin FOREIGN KEY (adminID) REFERENCES admin(adminID) ON DELETE CASCADE;

ALTER TABLE islem DROP CONSTRAINT fk_uyeID;

ALTER TABLE islem ADD CONSTRAINT fk_uyeID FOREIGN KEY (uyeID) REFERENCES uye(uyeID) ON DELETE CASCADE;


CREATE PROCEDURE sp_GirisKontrol
    @Email NVARCHAR(50),
    @Sifre NVARCHAR(50)
AS
BEGIN
    SELECT 'Admin' AS Rol
    FROM admin
    WHERE normalizedEmail = dbo.NormalizeEmail(@Email) AND sifre = @Sifre

    UNION

    SELECT 'Kullanici' AS Rol
    FROM uye
    WHERE normalizedEmail = dbo.NormalizeEmail(@Email) AND sifre = @Sifre
END;


CREATE PROCEDURE TeslimVer
    @uyeID INT,
    @kitapID INT,
    @islemTarihi DATE,
    @iadeTarihi DATE,
    @adminID INT
AS
BEGIN
    -- Ýþlem tablosuna yeni kayýt ekle
    INSERT INTO islem (uyeID, kitapID, islemTarihi, iadeTarihi, adminID, emanetDurumu)
    VALUES (@uyeID, @kitapID, @islemTarihi, @iadeTarihi, @adminID, 'EMANETTE');

    -- Kitap tablosundaki kitapDurumu'nu güncelle
    UPDATE kitap SET kitapDurumu = 0 WHERE kitapID = @kitapID;
END;


CREATE PROCEDURE TeslimAl
    @islemID INT,
    @kitapID INT
AS
BEGIN
    -- Ýþlem tablosundan ilgili kaydý sil
    DELETE FROM islem WHERE islemID = @islemID;

    -- Kitap tablosundaki kitapDurumu'nu güncelle
    UPDATE kitap SET kitapDurumu = 1 WHERE kitapID = @kitapID;
END;



CREATE FUNCTION dbo.NormalizeEmail(@email NVARCHAR(255))
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @normalizedEmail NVARCHAR(255);

    -- Küçük harflere dönüþtürme
    SET @normalizedEmail = LOWER(@email);

    -- Gereksiz boþluklarý kaldýrma
    SET @normalizedEmail = LTRIM(RTRIM(@normalizedEmail));

    RETURN @normalizedEmail;
END;

CREATE TRIGGER trg_Admin_Insert
ON admin
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE admin
    SET normalizedEmail = dbo.NormalizeEmail(i.eMail)
    FROM inserted i
    WHERE admin.adminID = i.adminID;
END;

CREATE TRIGGER trg_Uye_Insert
ON uye
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE uye
    SET normalizedEmail = dbo.NormalizeEmail(i.eMail)
    FROM inserted i
    WHERE uye.uyeID = i.uyeID;
END;

UPDATE admin
SET normalizedEmail = dbo.NormalizeEmail(eMail);

UPDATE uye
SET normalizedEmail = dbo.NormalizeEmail(eMail);




 select * from admin
 select * from uye
 select * from kitap
 select * from kategori
 select * from kitap_kategori
 select * from islem


 
