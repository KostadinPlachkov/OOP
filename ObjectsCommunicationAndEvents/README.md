## Table of Contents
1. Cohesion and Coupling  
2. Dependency Inversion Principle  
3. Events
      * Events vs Delegates  
      * EventHandlers  
      * Custom Events  
## Cohesion
Strong Cohesion - Example
```csharp
double sideA = 40, sideB = 69;
double angleAB = Math.PI / 3;
double sideC = sideA * sideA + sideB * sideB – 2 * sideA * sideB * Math.Cos(angleAB);
double sidesSqrtSum = Math.Sqrt(sideA) + Math.Sqrt(sideB) + Math.Sqrt(sideC);
```
Weak Cohesion - Example
```cs
class Magic
{
      void PrintDocument(Document d);
      void SendEmail(
      string recipient, string subject, string text);
      void CalculateDistanceBetweenPoints(
      int x1, int y1, int x2, int y2)
}
```
```cs
MagicClass.MakePizza("Fat Pepperoni");
MagicClass.WithdrawMoney("999e6");
MagicClass.OpenDBConnection();
```
## Coupling
Loose Coupling – Example
```cs
class Report : IReport
{
      public bool LoadFromFile(string fileName) {…}
      public bool SaveToFile(string fileName) {…}
}
class Printer
{
      public static void Print(IReport report) {…}
}
static void Main()
{
      Report myReport = new Report();
      myReport.LoadFromFile(@"C:\Reports\DailyReport.xml");
      Printer.Print(myReport);
}
```
Tight Coupling – Example
```cs
class MathParams
{
      public static double operand;
      public static double result;
}
class MathUtil
{
      public static void Sqrt()
      {
          MathParams.result = CalcSqrt(MathParams.operand);
      }
}
static void Main()
{
      MathParams.operand = 64;
      MathUtil.Sqrt();
      Console.WriteLine(MathParams.result);
}
```
## Spaghetti Code
```cs
//Combination of bad cohesion and tight coupling
class Report
{
      public void Print() {…}
      public void InitPrinter() {…}
      public void LoadPrinterDriver(string fileName) {…}
      public bool SaveReport(string fileName) {…}
      public void SetPrinter(string printer) {…}
}
class Printer
{
      public void SetFileName() {…}
      public static bool LoadReport() {…}
      public static bool CheckReport() {…}
}
```

## Dependency Examples
* Framework
* 3rd party library
* Database
* File system
* Email
* Web service
* System resource (e.g. clock)
* Configuration
* The new keyword
* Static method
* Global function
* Random generator
* Console
