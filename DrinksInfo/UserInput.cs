namespace DrinksInfo;
public class UserInput
{
    DrinkService drinkService = new();

    internal void GetCategoriesInput()
    {
        drinkService.GetCategories();
    }
}