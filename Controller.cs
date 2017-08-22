[HttpGet]
public FileContentResult ExportarFornecedores()
{
	List<DadosCadastraisViewModel> fornecedores = _fornecedorApp.GetAllFornecedores().OrderBy(f => f.NomeFantasia).ToList();
	string[] colunasIgnoradas = { "Estados", "StatusPreenchimento" };
	byte[] filecontent = Excel.ExportaExcel(fornecedores, "Fornecedore", true, colunasIgnoradas);
	return File(filecontent, Excel.ExcelContentType, "Fornecedores.xlsx");
}