using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceItem;

class InvoiceItem {
    private String id;
    private String desc;
    private int qty;
    private double unitPrice;

    
    public InvoiceItem(String id,String desc, int qty, double unitPrice)
    {
        this.id = id;
        this.desc = desc;
        this.qty = qty;
        this.unitPrice = unitPrice;
    }
    public String getId() { return id; }    
    public String getDesc() { return desc; }
    public int getQty() { return qty;}
    public void setQty(int Qty)
    { this.qty = Qty; }
    public double getUnitPrice() {  return unitPrice; }
    public void setUnitPrice(double UnitPrice) {  this.unitPrice = UnitPrice; }
    public double getTotal() {
        return unitPrice * qty;
    }
    public String toString() {
        return($"Id = {id}, desc = {desc}, qty = {qty}, unitPrice = {unitPrice}");
    }
    
}
class TestInvoiceItem {

    public static void Mainx()
    {   
        InvoiceItem i1 = new InvoiceItem("1","fruit",15,45);
        Console.WriteLine(i1.toString());
        i1.setUnitPrice(30);
        Console.WriteLine($"Total price {i1.getTotal()}");
        InvoiceItem i2 = new InvoiceItem("2", "meat", 2, 300);
        Console.WriteLine(i2.toString());
        Console.WriteLine($"Total price {i2.getTotal()}");
        i2.setUnitPrice(100);
        i2.setQty(50);
        Console.WriteLine($"Total price {i2.getTotal()}");
        Console.WriteLine(i2.toString());
    }
}
