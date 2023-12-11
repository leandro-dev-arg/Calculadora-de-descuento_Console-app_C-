using System;

namespace U3_programa3
{
    class Program
    {
        static void Main(string[] args)
        {
             float compra,desc,cfinal;
            Console.WriteLine("Que valor tiene tu compra?");
            compra=float.Parse(Console.ReadLine());

            if (compra>=5000){
                desc=(18*compra)/100;
                cfinal=compra-desc;
                Console.WriteLine("tu compra tiene 18% de descuento, el valor es "+ cfinal);
            }else if (compra>=1000 && compra<5000){
                desc=(10*compra)/100;
                cfinal=compra-desc;
                Console.WriteLine("tu compra tiene 10% de descuento, el valor es "+ cfinal);
            }else{
                Console.WriteLine("tu compra  no tiene  descuento, el valor es "+ compra);
            }
        }
    }
}
