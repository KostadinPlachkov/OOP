## Table of Contents
1. What is Unit Testing?
2. Unit testing Frameworks
    * Visual Studio Team Test
3. Unit Testing Best Practices
4. Mocking
5. Code and Test vs. Test Driven Development

## The 3A Pattern
1. **Arrange** all necessary preconditions and inputs
2. **Act** on the object or method under test
3. **Assert** that the expected results have occurred

**The 3A Pattern - Example**
```cs
[TestMethod]
public void TestDeposit()
{
      //Arrange
      BankAccount account = new BankAccount();
      //Act
      account.Deposit(125.0);
      account.Deposit(25.0);
      //Assert
      Assert.AreEqual(150.0, account.Balance, "Balance is wrong.");
}
```
## Code Coverage
Shows what **percent of the code** we've covered  
High code coverage means **less untested code**  
**70-80% coverage is excellent**  
