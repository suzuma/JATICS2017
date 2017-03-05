namespace JATICS2017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participantes", "sNombre", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Participantes", "sApellidos", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Participantes", "sEmail", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Participantes", "sTelefono", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participantes", "sTelefono", c => c.String());
            AlterColumn("dbo.Participantes", "sEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Participantes", "sApellidos", c => c.String(nullable: false));
            AlterColumn("dbo.Participantes", "sNombre", c => c.String(nullable: false));
        }
    }
}
