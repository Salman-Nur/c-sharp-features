using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP_examples
{


    //________________________________________________________________________________________________________________________________________
    //public class Computer : IComputer                                                                                                       |
    //{                                                                                                                                       |
    //    public int PowerSupplyCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }           |
    //    public int RAMPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }                     |
    //    public int ProcessorPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }               |
    //    public int HardDriveSpace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }               |
    //    public int USBConnectionPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }            |
    //    public int CDRomPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }                    |
    //}                                                                                                                                       |
    /// <summary>                                                                                                                             |
    /// Ei boro interface ta k vangte hobe. Ata ISP principle violate kore                                                                    |
    /// </summary>                                                                                                                            |
    //public interface IComputer                                                                                                              |
    //{                                                                                                                                       |
    //    int PowerSupplyCapacity { get; set; }                                                                                                |
    //    int RAMPower { get; set; }                                                                                                          |
    //    int ProcessorPower { get; set; }                                                                                                    |
    //    int HardDriveSpace { get; set; }                                                                                                    |
    //    int USBConnectionPort { get; set; }                                                                                                 |
    //    int CDRomPort { get; set; }                                                                                                         |
    //}                                                                                                                                       |
    //----------------------------------------------------------------------------------------------------------------------------------------

    public interface IPowerSupplySlot
    {
        int PowerSupplyCapacity { get; set; }
    }
    public interface IprocessorSlot
    {
        int ProcessorPower { get; set; }
    }
    public interface IRAMSlot
    {
        int RAMPower { get; set; }
    }
    public interface IHardDriveSlot
    {
        int HardDriveSpace { get; set; }
    }
    public interface IUSBSlot
    {
        int USBConnectionPort { get; set; }
    }
    public interface IROMSlot
    {
        int CDRomPort { get; set; } 
    }

    public class Computer : IPowerSupplySlot, IprocessorSlot, IRAMSlot, IROMSlot, IUSBSlot, IHardDriveSlot
    {
            public int PowerSupplyCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }           
            public int RAMPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }                     
            public int ProcessorPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }               
            public int HardDriveSpace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }               
            public int USBConnectionPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }            
            public int CDRomPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Laptop : IPowerSupplySlot, IprocessorSlot, IRAMSlot, IUSBSlot, IHardDriveSlot    //IROMSlot dorkar nei. Boro ta thakle ROM ta chole asto.Kintu akhon soto soto reusable interface e segregate kora hoiyese
    {
        public int PowerSupplyCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ProcessorPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RAMPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int USBConnectionPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HardDriveSpace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }








    //interface IReadable
    //{
    //    void Read();
    //}

    //interface IWritable
    //{
    //    void Write();
    //}

    //interface IReadWritable : IReadable, IWritable
    //{
    //}

    //class File : IReadWritable
    //{
    //    public void Read()
    //    {
    //        // Read file implementation
    //    }

    //    public void Write()
    //    {
    //        // Write to file implementation
    //    }
    //}

    //class Database : IReadWritable
    //{
    //    public void Read()
    //    {
    //        // Read database implementation
    //    }

    //    public void Write()
    //    {
    //        // Write to database implementation
    //    }
    //}

    //class Reader
    //{
    //    IReadable readable;

    //    public Reader(IReadable readable)
    //    {
    //        this.readable = readable;
    //    }

    //    public void Read()
    //    {
    //        readable.Read();
    //    }
    //}

    //class Writer
    //{
    //    IWritable writable;

    //    public Writer(IWritable writable)
    //    {
    //        this.writable = writable;
    //    }

    //    public void Write()
    //    {
    //        writable.Write();
    //    }
    //}

}
