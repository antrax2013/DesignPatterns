namespace Proxy;

interface IBankAccount
{
    public void WithDraw(decimal amount);
}

/*
// 1. Subject Interface
interface BankAccount {
    void withdraw(double amount);
}

// 2. Real Subject
class RealBankAccount implementsBankAccount {
    private double balance = 500.00;

    @Override
    public void withdraw(double amount) {
        balance -= amount;
        System.out.println("Withdrawal successful. Remaining balance: $" + balance);
    }
}

// 3. Proxy Class
class SecurityProxy implements BankAccount {
    private RealBankAccount realAccount;
    private String userRole;

    public SecurityProxy(String userRole) {
        this.userRole = userRole;
    }

    @Override
    public void withdraw(double amount) {
        // Protection/Access control logic
        if (userRole != null && userRole.equals("ADMIN")) {
            if (realAccount == null) {
                realAccount = new RealBankAccount();
            }
            realAccount.withdraw(amount);
        } else {
            System.out.println("Access Denied! Only ADMIN users can withdraw funds.");
        }
    }
}

// 4. Client Code
public class Main {
    public static void main(String[] args) {
        BankAccount userProxy = new SecurityProxy("USER");
        BankAccount adminProxy = new SecurityProxy("ADMIN");

        System.out.println("--- Standard User attempting withdrawal ---");
        userProxy.withdraw(100.00);

        System.out.println("\n--- Admin attempting withdrawal ---");
        adminProxy.withdraw(100.00);
    }
}
*/
