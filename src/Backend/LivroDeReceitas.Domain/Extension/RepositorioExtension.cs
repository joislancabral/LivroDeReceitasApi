using Microsoft.Extensions.Configuration;

namespace LivroDeReceitas.Domain.Extension
{
    public static class RepositorioExtension
    {
        public static string GetNomeDatabase(this IConfiguration configurationManager)
        {
            var nomeDatabase = configurationManager.GetConnectionString("NomeDatabase");

            return nomeDatabase;
        }

        public static string GetConnectionString(this IConfiguration configurationManager)
        {
            var conexao = configurationManager.GetConnectionString("Conexao");

            return conexao;
        }
    }
}
