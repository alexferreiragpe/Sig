select distinct Id_Produto,sum(qtde) as total from produto group by Id_Produto;

Update Produto set  Produto.Qtde=(select distinct Id_Produto,sum(qtde) from produto group by Id_Produto)+itensnotafiscal.quantidade from Produto inner join ItensNotaFiscal on Produto.Id_Produto=ItensNotaFiscal.Id_Produto