using FluentMigrator;

namespace LivroDeReceitas.Infrastructure.Migrations.Versoes
{
    [Migration((long) NumeroVersoes.CriarTabelaUsuario, "Cria tabela usuario")]
    public class Versao0000001 : Migration
    {
        public override void Down()
        {
           //Apaga uma tabela
        }

        public override void Up()
        {
            //Criando uma tabela no banco de dados
            var tabela = VersaoBase.InserirColunasPadrao(Create.Table("Usuario"));

                //Nome coluna         //tipo        //contrain
                tabela.WithColumn("Nome").AsString(100).NotNullable()
                .WithColumn("Email").AsString().NotNullable()
                .WithColumn("Senha").AsString(2000).NotNullable()
                .WithColumn("Telefone").AsString(14).NotNullable();
        }
    }
}
