
using System;
using System.IO;
public class ATM_log {
    public string file_create(string filename) {
        string folderPath = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(folderPath, filename);
        if (!File.Exists(filePath)) {
            File.Create(filePath).Close();
            Console.WriteLine("File created: " + filePath);
        }
        else {
            Console.WriteLine("File already exists: " + filePath);
        }
        return filePath;
    }
    public void log_entries(string entry, string path) {
        File.AppendAllText(path, entry + Environment.NewLine);
    }
}
public class ATM_Log_Prg {
    public string datetime_get() {
        return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
    public static void Main(string[] args) {
        string time_now = "";
        string log_str = "";
        string path = "";
        string correct_username = "Chithu";
        int correct_pin = 2005;
        ATM_log atm_log = new ATM_log();
        ATM_Log_Prg atm_log_prg = new ATM_Log_Prg();
        path = atm_log.file_create("atm_log.txt");
        int balance = 100000;
        Console.WriteLine("Enter your Username:");
        string username = Console.ReadLine();
        if (username == correct_username){
        Console.WriteLine("Enter your ATM PIN:");
            int pin = Convert.ToInt32(Console.ReadLine());

            if (pin == correct_pin) {

                Console.WriteLine("\nWelcome " + username);
                time_now = atm_log_prg.datetime_get();
                log_str = "Successful Login by " + username + " at " + time_now;
                atm_log.log_entries(log_str, path);
                Console.WriteLine("\nEnter your Choice");
                Console.WriteLine("A. Check Balance");
                Console.WriteLine("B. Withdraw Money");
                Console.WriteLine("C. Deposit Money");
                string cha =  Console.ReadLine().ToUpper();
                switch (cha) {
                    case "A":
                        Console.WriteLine("Your Balance is " + balance);
                        time_now = atm_log_prg.datetime_get();
                        log_str = "Balance Checked by " + username + " at | " + time_now+" | Status-Completed";
                        atm_log.log_entries(log_str, path);
                        break;
                    case "B":
                        Console.WriteLine("Enter the amount to withdraw");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw > 0 && withdraw <= balance) {
                            balance = balance - withdraw;
                            Console.WriteLine("You have withdrawn " + withdraw);
                            Console.WriteLine("Your Balance is " + balance);
                            time_now = atm_log_prg.datetime_get();
                            log_str = "Successfully Withdrawn by " + username + " at | " + time_now+" | Status-Completed" ;
                            atm_log.log_entries(log_str, path);
                        }
                        else {
                            Console.WriteLine("Invalid Amount or Insufficient Balance");
                            time_now = atm_log_prg.datetime_get();
                            log_str = "Failed Withdrawal by " + username + " at | " + time_now+" | Status-Failed" ;
                            atm_log.log_entries(log_str, path);
                        }
                        break;
                    case "C":
                        Console.WriteLine("Enter the amount to deposit");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        if (deposit > 0) {
                            Console.WriteLine("Enter the mode of deposit");
                            Console.WriteLine("A. Cash");
                            Console.WriteLine("B. UPI");
                            string mode = Console.ReadLine().ToUpper();
                            if (mode == "A") {
                                balance = balance + deposit;
                                Console.WriteLine("Deposited " + deposit + " in Cash");
                            }
                            else if (mode == "B") {
                                balance = balance + deposit;
                                Console.WriteLine("Deposited " + deposit + " through UPI");
                            }
                            else {
                                Console.WriteLine("Invalid mode of deposit");
                                break;
                            }
                            Console.WriteLine("Your Balance is " + balance);
                            time_now = atm_log_prg.datetime_get();
                            log_str = "Successfully Deposited by " + username + " at | " + time_now+" | Status-Completed" ;
                            atm_log.log_entries(log_str, path);
                        }
                        else {
                            Console.WriteLine("Enter a valid deposit amount");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid Choice");
                        time_now = atm_log_prg.datetime_get();
                        log_str = "Invalid Choice Entered by " + username +" at | " + time_now + " | Status-Failed";
                        atm_log.log_entries(log_str, path);
                        break;
                }
            }
        }
            else {
                Console.WriteLine("Invalid Username or PIN");
                time_now = atm_log_prg.datetime_get();
                log_str = "Failed Login Attempt by " + username + " at | " + time_now;
                atm_log.log_entries(log_str, path);
            }
        }
    }
