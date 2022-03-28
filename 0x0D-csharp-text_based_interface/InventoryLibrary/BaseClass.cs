using System;

///<summary> The base clase </summary>
public class BaseClass
{
    public string id { get; set;}
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }

    public BaseClass(String id = null, DateTime date_created = default(DateTime), DateTime date_updated = default(DateTime))
    {
        if (id == null)
            this.id = System.Guid.NewGuid().ToString();
        else
            this.id = id;
        if (date_created == default(DateTime))
            this.date_created = DateTime.Now;
        else
            this.date_created = date_created;
        if (date_updated == default(DateTime))
           this.date_updated = DateTime.Now;
        else
            this.date_updated = date_updated;
    }
}
