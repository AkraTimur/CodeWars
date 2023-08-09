namespace Null_Conditional_Operator__C__6._0_
{
    public static class CarInformation
    {
        public static int GetNumberOfGears(this Car car)
        {
            return car?.Engine?.GearBox?.NumberOfGears ?? -1;
        }
    }
}
