-- Actualiza data form1 Abril 2013
INSERT INTO dbo.BNSBF14_Formulario1
SELECT * FROM [10.7.12.32].bn_ahsb.dbo.BNSBF14_Formulario1
WHERE f14_cPeriodo='042013'

-- Actualiza data form2 Abril 2013
INSERT INTO dbo.BNSBF15_Formulario2
SELECT * FROM [10.7.12.32].bn_ahsb.dbo.BNSBF15_Formulario2
WHERE f15_cPeriodo='042013'