# DentalClinic

DentalClinic to aplikacja desktopowa stworzona w C# z wykorzystaniem Windows Forms oraz Microsoft SQL Server. Aplikacja ma na celu wspomaganie zarządzania operacjami w gabinecie stomatologicznym, takimi jak zarządzanie danymi pacjentów, historią wizyt, planowaniem wizyt oraz uwierzytelnianiem użytkowników.

## Funkcje
- **Zarządzanie użytkownikami**:
  - Logowanie do aplikacji przy użyciu nazwy użytkownika i hasła.
  - Profil użytkownika zawierający dane osobowe (np. imię, nazwisko, e-mail).

- **Historia wizyt**:
  - Wyświetlanie historii wizyt pacjentów.
  - Szczegóły wizyt, w tym ich status.

- **Planowanie wizyt**:
  - Możliwość zapisywania, przeglądania i anulowania wizyt.

- **Integracja z bazą danych**:
  - Bezpieczny dostęp do danych za pomocą ADO.NET.
  - Obsługa zapytań SQL i procedur składowanych.

- **Dynamiczna tabela danych**:
  - Wyświetlanie wizyt w DataGridView z dodatkowymi funkcjami, takimi jak przyciski do anulowania wizyt.

## Szczegóły techniczne
- **Język programowania**: C#
- **Framework**: Windows Forms
- **Baza danych**: SQL Server (MSSQL)
- **IDE**: Visual Studio

## Kluczowe funkcjonalności
1. **Ładowanie historii wizyt**:
   - Pobieranie danych z bazy danych za pomocą zapytań SQL i procedur składowanych.
   - Filtracja wizyt w oparciu o wybrany status w polu wyboru (np. "Wszystkie wizyty").

2. **Połączenie z bazą danych**:
   - Łańcuch połączenia:
     ```plaintext
     Server=localhost;Database=DentalClinic;Integrated Security=True;
     ```
   - Wykorzystywane obiekty: `SqlConnection`, `SqlCommand`, `SqlDataAdapter`.

3. **Dynamiczne kolumny w tabeli**:
   - Dodawanie niestandardowych kolumn w DataGridView, np. z przyciskiem "Anuluj wizytę".

## Instalacja i konfiguracja

### Wymagania
- System operacyjny: Windows
- Zainstalowany Microsoft SQL Server
- Visual Studio z .NET Framework

### Konfiguracja bazy danych
1. Utwórz bazę danych o nazwie `DentalClinic`.
2. Zaimportuj odpowiednie tabele i procedury składowane z plików projektu.

### Uruchomienie aplikacji
1. Otwórz projekt w Visual Studio.
2. Skonfiguruj łańcuch połączenia w plikach projektu tak, aby wskazywał na lokalny serwer SQL.
3. Uruchom projekt za pomocą przycisku **Start**.

## Struktura projektu
- **Pliki projektu**:
  - `TwojProfil.cs`: Obsługa profilu użytkownika.
  - `ZapisWizyty.cs`: Formularz do zapisywania wizyt.
  - `WizytaOwo.cs`: Zarządzanie szczegółami wizyt.
  - `LogowanieUz.cs`: Logowanie użytkowników.
- **Baza danych**:
  - Tabele: `Users`, `Visits`, `Appointments`.
  - Procedury składowane: `GetVisitsByStatus`, `CancelVisit`.

## Autorzy
Mikołaj Melnyk

---
