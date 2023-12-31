namespace P06VehicleDealership.Shared.Languages
{
  public class LanguageService : ILanguageService
  {
    public Dictionary<string, Dictionary<string, string>> loadedLanguages = new Dictionary<string, Dictionary<string, string>>();

    public LanguageService()
    {
      LoadLanguages();
    }

    public string GetLanguage(string language, string keyWord)
    {
      if (keyWord == null)
      {
        return keyWord;
      }

      if (loadedLanguages.TryGetValue(language, out
          var languageTranslations))
      {
        if (languageTranslations.TryGetValue(keyWord, out
            var translation))
        {
          return translation;
        }
      }

      return keyWord;
    }

    public void LoadLanguages()
    {
      loadedLanguages = new Dictionary<string, Dictionary<string, string>> {
        {
          "english",
          new Dictionary < string,
          string > {
            {
              "WelcomeTitle",
              "Welcome to the car dealership!"
            },
            {
              "DealershipDescription",
              "Discover a modern car dealership where innovative design meets advanced technology. Our experienced advisors will help you find the perfect vehicle, offering you a unique shopping experience in complete comfort and elegance."
            },
            {
              "LoginTitle",
              "Login"
            },
            {
              "EmailLabel",
              "Email:"
            },
            {
              "PasswordLabel",
              "Password"
            },
            {
              "LoginButton",
              "Login In"
            },
            {
              "RegisterTitle",
              "Register"
            },
            {
              "UsernameLabel",
              "User name"
            },
            {
              "RegisterButton",
              "Register"
            },
            {
              "SettingsTitle",
              "Settings"
            },
            {
              "ChooseLanguageLabel",
              "Choose your language"
            },
            {
              "PolishOption",
              "Polski"
            },
            {
              "EnglishOption",
              "English"
            },
            {
              "SaveButton",
              "Save"
            },
            {
              "CreateVehicleTitle",
              "Create new vehicle"
            },
            {
              "EditVehicleTitle",
              "Edit Vehicle"
            },
            {
              "DeleteButton",
              "Delete"
            },
            {
              "LoadingVehicles",
              "Loading vehicles..."
            },
            {
              "VehiclesListTitle",
              "Full list of vehicles"
            },
            {
              "CreateNewVehicleLink",
              "Create new vehicle"
            },
            {
              "SearchButton",
              "Search"
            },
            {
              "EditButton",
              "Edit"
            },
            {
              "PreviousButton",
              "Previous"
            },
            {
              "NextButton",
              "Next"
            },
            {
              "ModelLabel",
              "Model"
            },
            {
              "FuelLabel",
              "Fuel"
            },
            {
              "UpdateButton",
              "Save"
            },
            {
              "NavbarBrand",
              "Vehicle dealership"
            },
            {
              "NavigationMenuTitle",
              "Navigation menu"
            },
            {
              "HomeNavLink",
              "Home"
            },
            {
              "VehiclesNavLink",
              "Vehicles"
            },
            {
              "SettingsNavLink",
              "Settings"
            },
            {
              "IdColumn",
              "Id"
            },
            {
              "ModelColumn",
              "Model"
            },
            {
              "FuelColumn",
              "Fuel"
            },
            {
              "LogoutTitle",
              "Logout"
            },
            {
              "AboutTitle",
              "About"
            },
            {
              "ChooseTheme",
              "Choose theme"
            },
            {
              "UserNotLoggedInTitle",
              "Whoops! You're not allowed to see this page."
            },
            {
              "Please",
              "Please"
            },
            {
              "LoginTitleApp",
              "login"
            },
            {
              "Or",
              "or"
            },
            {
              "RegisterTitleApp",
              "register"
            },
            {
              "NewAccount",
              "for a new account."
            },
            {
              "PageNotFound",
              "Page not found!"
            },
            {
              "PageNotFoundSubtitle",
              "Sorry, there's nothing at this address..."
            },
            {
              "Customer",
              "Customer"
            },
            {
              "CreateAccountLabel",
              "Create new account!"
            },
            {
              "ErrorMessageLabel",
              "Incorrect credentials!"
            },
            {
              "NotRegisteredLabel",
              "Not registered?"
            },
            {
              "ConfirmPasswordLabel",
              "Confirm password"
            },
            {
              "CreateAccountLabel2",
              "Create an account"
            },
            {
              "NonNullFieldErrorMessage",
              "Error, none of the fields can be empty!"
            },
            {
              "WrongEmailMessageError",
              "Error, wrong email!"
            },
            {
              "WrongPasswordMessageError",
              "Error, password is too weak!"
            },
            {
              "WrongConfPasswordMessageError",
              "Error, passwords are not the same!"
            },

            {
              "CreateAccountErrorMessage",
              "Error, failed to create new account!"
            },
            {
              "AccountCreatedMessage",
              "Account created successfully!"
            },
            {
              "WrongCredentialsMessage",
              "Error, wrong login credentials!"
            },
            {
              "NextPageButtonText",
              "Next page"
            },
            {
              "PreviousPageButtonText",
              "Previous page"
            },
            {
              "LanguageLabel",
              "Language"
            },
            {
              "ToogleThemeText",
              "Toggle theme"
            },
          }
        },
        {
          "polski",
          new Dictionary < string,
          string > {
            {
              "WelcomeTitle",
              "Witamy w salonie samochodowym!"
            },
            {
              "DealershipDescription",
              "Odkryj nowoczesny salon samochodowy, gdzie innowacyjny design spotyka się z zaawansowaną technologią. Nasi doświadczeni doradcy pomogą Ci znaleźć idealny pojazd, oferując wyjątkowe doświadczenie zakupowe w pełnym komforcie i elegancji."
            },
            {
              "LoginTitle",
              "Logowanie"
            },
            {
              "EmailLabel",
              "Email:"
            },
            {
              "PasswordLabel",
              "Hasło"
            },
            {
              "LoginButton",
              "Zaloguj"
            },
            {
              "RegisterTitle",
              "Rejestracja"
            },
            {
              "UsernameLabel",
              "Nazwa użytkownika"
            },
            {
              "RegisterButton",
              "Zarejestruj"
            },
            {
              "SettingsTitle",
              "Ustawienia"
            },
            {
              "ChooseLanguageLabel",
              "Wybierz język"
            },
            {
              "PolishOption",
              "Polski"
            },
            {
              "EnglishOption",
              "English"
            },
            {
              "SaveButton",
              "Zapisz"
            },
            {
              "CreateVehicleTitle",
              "Stwórz nowy pojazd"
            },
            {
              "EditVehicleTitle",
              "Edytuj Pojazd"
            },
            {
              "DeleteButton",
              "Usuń"
            },
            {
              "LoadingVehicles",
              "Ładowanie pojazdów..."
            },
            {
              "VehiclesListTitle",
              "Pełna lista pojazdów"
            },
            {
              "CreateNewVehicleLink",
              "Utwórz nowy pojazd"
            },
            {
              "SearchButton",
              "Szukaj"
            },
            {
              "EditButton",
              "Edytuj"
            },
            {
              "PreviousButton",
              "Poprzednia"
            },
            {
              "NextButton",
              "Następna"
            },
            {
              "ModelLabel",
              "Model"
            },
            {
              "FuelLabel",
              "Paliwo"
            },
            {
              "UpdateButton",
              "Zapisz"
            },
            {
              "NavbarBrand",
              "Salon samochodowy"
            },
            {
              "NavigationMenuTitle",
              "Menu nawigacyjne"
            },
            {
              "HomeNavLink",
              "Strona główna"
            },
            {
              "VehiclesNavLink",
              "Pojazdy"
            },
            {
              "SettingsNavLink",
              "Ustawienia"
            },
            {
              "IdColumn",
              "Id"
            },
            {
              "ModelColumn",
              "Model"
            },
            {
              "FuelColumn",
              "Paliwo"
            },
            {
              "LogoutTitle",
              "Wyloguj"
            },
            {
              "AboutTitle",
              "O nas"
            },
            {
              "ChooseTheme",
              "Wybierz motyw"
            },
            {
              "UserNotLoggedInTitle",
              "Jesteś niezalogowany!"
            },
            {
              "Please",
              "Proszę"
            },
            {
              "LoginTitleApp",
              "zaloguj się"
            },
            {
              "Or",
              "lub"
            },
            {
              "RegisterTitleApp",
              "załóż konto"
            },
            {
              "NewAccount",
              "."
            },
            {
              "PageNotFound",
              "Strona nieistnieje!"
            },
            {
              "PageNotFoundSubtitle",
              "Przepraszamy, ale strona o takim adresie nie istnieje..."
            },
            {
              "Customer",
              "Klient"
            },
            {
              "CreateAccountLabel",
              "Załóż nowe!"
            },
            {
              "ErrorMessageLabel",
              "Błędne dane logowania!"
            },
            {
              "NotRegisteredLabel",
              "Nie masz konta?"
            },
            {
              "ConfirmPasswordLabel",
              "Potwierdź hasło"
            },
            {
              "CreateAccountLabel2",
              "Utwórz konto"
            },
            {
              "NonNullFieldErrorMessage",
              "Błąd, żadne z pól nie może być puste!"
            },
            {
              "WrongEmailMessageError",
              "Błąd, nieprawidłowy adres email!"
            },
            {
              "WrongPasswordMessageError",
              "Błąd, hasło jest za słabe!"
            },
            {
              "WrongConfPasswordMessageError",
              "Błąd, hasła nie są jednakowe!"
            },
            {
              "CreateAccountErrorMessage",
              "Błąd, nie udało się utworzyć nowego konta!"
            },
            {
              "AccountCreatedMessage",
              "Konto utworzone poprawnie!"
            },
            {
              "WrongCredentialsMessage",
              "Błąd, nieprawidłowe dane logowania!"
            },
            {
              "NextPageButtonText",
              "Następna strona"
            },
            {
              "PreviousPageButtonText",
              "Poprzednia strona"
            },
            {
              "LanguageLabel",
              "Język"
            },
            {
              "LanguageSubLabel",
              "Wybierz język aplikacji"
            },
                        {
              "ToogleThemeText",
              "Zmień tło"
            },
          }
        }
      };
    }
  }
}