namespace AgenstvoNedvizimosty.Context.Contracts.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Putevka : BaseAuditEntity
    {
        /// <summary>
        /// ОТКУДА БЕРЕМ  ДАННЫЕ
        /// </summary>
         public List <PutTargetItem> PutTargetItem { get; set; }

        /// <summary>
        /// ID ПУТЕВК
        /// </summary>
         public Guid TargetID { get; set; }

        /// <summary>
        /// ID ТУРИСТОВ
        /// </summary>
         public Guid TuristID { get; set;}

        /// <summary>
        /// ID ТУР ОПЕРАТОРОВ
        /// </summary>
         public Guid TurOperID { get; set; }
    }
}
