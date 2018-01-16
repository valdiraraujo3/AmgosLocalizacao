USE amigos_localizacao
GO
CREATE TABLE Amigos (
    	id INT NOT NULL,
	cidade VARCHAR(100) NOT NULL,
	nome_amigo VARCHAR(100) NOT NULL,
	estado VARCHAR(100) NOT NULL,
	location [geography] NULL,
	latitude FLOAT(8) NOT NULL,
	longitude FLOAT(8) NOT NULL

  PRIMARY KEY (id)
);

GO

INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(1, 'Barueri', 'Amigo1', 'São Paulo', geography::STGeomFromText ('POINT(-23.5057 -46.879)',4326), -23.5057, -46.879);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(2, 'Cotia', 'Amigo2', 'São Paulo', geography::STGeomFromText ('POINT(-23.6022 -46.919)',4326), -23.6022, -46.919);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(3, 'Embu das Artes', 'Amigo3', 'São Paulo', geography::STGeomFromText ('POINT(-23.6437 -46.8579)',4326), -23.6437, -46.8579);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(4, 'Osasco', 'Amigo4', 'São Paulo', geography::STGeomFromText ('POINT(-23.5324 -46.7916)',4326), -23.5324, -46.7916);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(5, 'São Bernardo do Campo', 'Amigo5', 'São Paulo', geography::STGeomFromText ('POINT(-23.6914 -46.5646)',4326), -23.6914, -46.5646);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(6, 'Santo André', 'Amigo6', 'São Paulo', geography::STGeomFromText ('POINT(-23.6737 -46.5432)',4326), -23.6737, -46.5432);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(7, 'São Caetano do Sul', 'Amigo7', 'São Paulo', geography::STGeomFromText ('POINT(-23.6229 -46.5548)',4326), -23.6229, -46.5548);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(8, 'São Paulo', 'Amigo8', 'São Paulo', geography::STGeomFromText ('POINT(-23.5329 -46.6395)',4326), -23.5329, -46.6395);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(9, 'Carapicuíba', 'Amigo9', 'São Paulo', geography::STGeomFromText ('POINT(-23.5235 -46.8407)',4326), -23.5235, -46.8407);
GO
INSERT INTO Amigos([id],[cidade],[nome_amigo],[estado],[location],[latitude],[longitude]) values
(10, 'Itapevi', 'Amigo10', 'São Paulo', geography::STGeomFromText ('POINT(-23.5488 -46.9327)',4326), -23.5488, -46.9327);