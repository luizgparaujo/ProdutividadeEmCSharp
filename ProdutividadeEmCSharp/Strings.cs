namespace ProdutividadeEmCSharp
{
    public class Strings
    {
        /// <summary>
        /// Criando strings mais legíveis
        /// </summary>
        /// <returns></returns>
        public string CriarStringsMaisLegíveis()
        {
            var livro = new Livro();
            var mensagem = "";

            // Como era
            //mensagem = string.Format("{0} é o livro de {1}", livro.Titulo, livro.Autor);

            // Usando interpolação de strings
            //mensagem = $"{livro.Titulo} é o livro de {livro.Autor}";

            // Usando o caractere @ para preservar espaços, tabulações e quebras de linhas em strings
            //mensagem = "Amigo leitor,\n\n\tobrigado por ter adquirido este livro. " +
            //   "Esperamos que ele o ajude em sua jornada diária de trabalho.\n\nBom estudo!\nCláudio Ralha";

            mensagem = @"Amigo leitor,

                 obrigado por ter adquirido este livro. Esperamos que ele o ajude em sua jornada diária de trabalho.
                 
                 Bom estudo!
                 Cláudio Ralha";

            var sql = @"SELECT * 
                          FROM livros 
                         WHERE autor = 'Claudio Ralha'";

            var pastaDocumentos = "";
            pastaDocumentos = "C:\\Program Files\\Docker\\Docker";
            pastaDocumentos = @"C:\Program Files\Docker\Docker";

            return mensagem;
        }

        #region 1.2 Convertendo strings 
        #endregion

        #region 1.3 Formatando strings 
        #endregion

        #region 1.4 Sorteando uma string de um array ou lista 
        #endregion

        #region 1.5 Gerando uma string randômica 
        #endregion

        #region 1.6 Utilizando comentários especiais para sinalizar o código 
        #endregion

        #region 1.7 Utilizando expressões regulares para validar dados 
        #endregion


    }

    public class Livro
    {
        public string Titulo { get; set; } = "Produtividade em C#";
        public string Autor { get; set; } = "Cláudio Ralha";
    }
}
