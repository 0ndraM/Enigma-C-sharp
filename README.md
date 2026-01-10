# Enigma C#

Simulátor šifrovacího stroje Enigma vytvořený v C#

**Autor:** Mühlhandel Ondřej

## O projektu

Tento projekt je počítačový simulátor historického šifrovacího stroje Enigma. Program demonstruje vnitřní fungování tohoto legendárního zařízení a ukazuje, jak jednoduché je pomocí moderního programovacího jazyka emulovat komplexní mechanické zapojení stroje Enigma.

## Funkce

- 🔐 Šifrování a dešifrování textu pomocí Enigma algoritmu
- ⚙️ Simulace třech rotorů s nastavitelnými pozicemi
- 🔄 Reflektor pro symetrické šifrování
- 💾 Ukládání a nahrávání zašifrovaného textu ze souborů
- 🎨 Grafické uživatelské rozhraní (Windows Forms)
- 📊 Vizualizace rotace rotorů během šifrování

## Technologie

- **Jazyk:** C#
- **Framework:** .NET Framework
- **UI:** Windows Forms
- **IDE:** Visual Studio

## Požadavky

- Windows (7 nebo novější)
- .NET Framework 4.5 nebo novější
- Visual Studio 2015 nebo novější (pro vývoj)

## Instalace a spuštění

1. Naklonujte repozitář:
   ```bash
   git clone https://github.com/0ndraM/Enigma-C-sharp.git
   ```

2. Otevřete `ROP.sln` ve Visual Studiu

3. Sestavte projekt (Build → Build Solution nebo `Ctrl+Shift+B`)

4. Spusťte aplikaci (Debug → Start Debugging nebo `F5`)

## Použití

1. Zadejte text do vstupního pole
2. Nastavte počáteční pozice rotorů podle potřeby
3. Text se automaticky šifruje/dešifruje při psaní
4. Použijte tlačítka pro uložení nebo nahrání textu ze souboru

## Struktura projektu

```
ROP/
├── MainForm.cs       - Hlavní formulář aplikace
├── Rotors.cs         - Implementace rotorů Enigmy
├── Settings.cs       - Okno nastavení
├── About.cs          - Okno O aplikaci
└── Program.cs        - Vstupní bod aplikace
```

## License

Tento projekt je vytvořen pro vzdělávací účely.

