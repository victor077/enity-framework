<!-- # enity-framework

-- anotações importantes sobre o curso 

existe duas maneiras de se fazer a criação de tabela sendo a (data anotations e antity api)
para criar uma função que seja preciso ser feito direto no banco de dados será feito no metodo 
 protected override void Up(MigrationBuilder migrationBuilder)

 sobre migrations: 
 para fazer as migrations é preciso ter os seguinte pacotes 
 - Desing 
 - Tools

comandos utilizados na migrations 
-  add-Migrations = nova migration
- Drop-Database = Dropa seu banco de dados
- Get-DbContext =  pega informações sobre o seu dbcontext 
- dotnet ef migrations remove = remove a ultima migração feita
- Script-Migration = Cria um arquivo sql para saber tudo que está sendo feito no banco
- dotnet ef database update o arquivo de migração  = Atualiza a nova migração que foi feita no back e passa elas para o banco -->
<!-- 
scripts sql 

gera arquivo com validações 
dotnet ef migrations script --idempotent --output dempotent.SQL
gera arquivo sem validaçõs 
dotnet ef migrations add PrimeiraMigracao  -->