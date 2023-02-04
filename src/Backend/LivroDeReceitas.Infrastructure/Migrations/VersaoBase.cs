using FluentMigrator.Builders.Create.Table;
using FluentMigrator.Expressions;

namespace LivroDeReceitas.Infrastructure.Migrations
{
    public static class VersaoBase
    {
        public static ICreateTableColumnOptionOrWithColumnSyntax InserirColunasPadrao(ICreateTableWithColumnOrSchemaOrDescriptionSyntax tabela)
        {
            //Criando o nome da coluna//criando Tipo//Criando a chave primaria
            return tabela.WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("DataCriacao").AsDateTime().NotNullable();
        }
    }
}
