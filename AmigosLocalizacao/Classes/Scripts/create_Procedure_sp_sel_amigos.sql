USE amigos_localizacao
GO
/*
Autor: Francisco Valdir Araújo

Testes: EXEC sp_amigos @id = 1

*/
CREATE PROCEDURE sp_sel_amigos
		 @codigo integer
AS
	SET NOCOUNT ON; 
		DECLARE @top INTEGER = 3	
		DECLARE @lat DECIMAL(12,9) = (select latitude from Amigos where id = @codigo)
		DECLARE @long DECIMAL(12,9) = (select longitude from Amigos where id = @codigo)
		DECLARE @local geography = geography::Point(@long, @lat, 4326)

SELECT TOP (@top) 
	 Id
	,Nome_Amigo
	,Cidade
	,location.ToString() as Point
	,CAST(@local.STDistance(location)AS INT) Distancia	 
FROM Amigos
WHERE CAST(@local.STDistance(location)AS INT) > 0
	ORDER BY Distancia ASC