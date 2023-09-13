using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String fristName;
    String lastName;
    double balance;

    public cardHolder(String cardNum,int pin,String fristName,String lastName,double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.fristName = fristName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNum() {
    return cardNum;
    }

    public int getPin()
    {
        return pin;
    }
     public String getFristName()
    {
        return fristName;
    }

    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

      public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFristName(String newFristName)
    {
        fristName = newFristName;
    }
    public void LastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void Balance(double newBalance)
    {
        balance = newBalance;
    }

    public static void main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("please choose");
            Console.WriteLine("1. deposit");
            Console.WriteLine("2. withdraw");
            Console.WriteLine("3. showbalance");
            Console.WriteLine("4. Exit");

        }
        void depsit(cardHolder currentUser)
        {
            Console.WriteLine("how much deposit");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.Balance(deposit);
            Console.WriteLine("thank you for your response your current balance is"+ currentUser.getBalance());
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("how much do you wanna withdraw");
            double withdrawl = Double.Parse(Console.ReadLine());

            //check use has money
            if(currentUser.getBalance() > withdrawl)
            {
                Console.WriteLine("sorry no enough amount of cash");
            }
            else
            {
               
                currentUser.Balance(currentUser.getBalance() - withdraw);
            }

        }
    }
}