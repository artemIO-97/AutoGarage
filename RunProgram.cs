using AutoGarage;

var startMenu = new StartMenu();
startMenu.PrintStartMenu();
do
{
startMenu.InpytStartMenu = Convert.ToInt32(Console.ReadLine());
startMenu.GoToNextScreen(startMenu.InpytStartMenu);
} while (!startMenu.returnBool); // не понимаю почему даже при переходе в другое меню всё равно висит данный ввод


