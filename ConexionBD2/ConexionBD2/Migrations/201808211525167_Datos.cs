namespace ConexionBD2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Datos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.datosPersonales", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.datosPersonales", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.datosPersonales", "Direccion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.datosPersonales", "Direccion", c => c.String());
            AlterColumn("dbo.datosPersonales", "Apellido", c => c.String());
            AlterColumn("dbo.datosPersonales", "Nombre", c => c.String());
        }
    }
}
