# IPA_Gambling

VGTU IPA Arklių lenktynių žaidimas.

Instrukcijos:
1. Jei automatiškai nepasileido pilnu ekranu, tai paleisti žaidimą pilnu ekranu. Idealiausia su 1920x1080 rezoliuciją
2. Įvesti statomų pinigų kieki, kuris yra lygus arba mažesnis turimam kiekiui. Laimėjus gausit dvigubai, pralaimėjus trigubai bus atimta.
3. Pasirinkite arkliuka nuo 1 iki 4, skaiciuojama nuo viršaus iki apačios.
4. Žiurėkite lenktynes, ir po lenktynių įveskite y jei norite žaisti toliau.

![alt text](https://raw.githubusercontent.com/GioXmen/IPA_Gambling/develop/AppImages/Gambling_screen.png)
![alt text](https://raw.githubusercontent.com/GioXmen/IPA_Gambling/develop/AppImages/Win_screen.png)
![alt text](https://raw.githubusercontent.com/GioXmen/IPA_Gambling/develop/AppImages/Loose_screen.png)


# Dokumentacija
## Objektai / Masyvai / Kintamieji
| objektas / masyvas | classpath |
| ------ | ------ | 
| List<Horse> horses |GamblingGame.Program |
| int Money |GamblingGame.Program |
| int Bet |GamblingGame.Program |
| Boolean exit |GamblingGame.Program |
| ------ | ------ |
| string id |GamblingGame.Horses |
| int LuckScore |GamblingGame.Horses |
| int RealScore |GamblingGame.Horses |
| ------ | ------ |
| String space |GamblingGame.Draw |
| string result |GamblingGame.Draw |
| string[] horse |GamblingGame.Draw |

## Objektų kintamieji
| Kintamasis | Classpath |Apibudinimas |
| ------ | ------ | ------ | 
| id | GamblingGame.Horses | Arkliuko id  |
| LuckScore | GamblingGame.Horses | Arkliuko laimės taškai|
| RealScore | GamblingGame.Horses | Arkliuko tikrieji taškai/nueitas kelias|

## Funkcijos
| funkcija | apibrėžimas | classpath |
| ------ | ------ | ------ |
| SetWindowSize() | Nustato konsolės lango dydi| GamblingGame.Program |
| ShowWindow() | Parodo konsolę su nustatytais parametrais| GamblingGame.Program |
| horse() | Klasė kuri pavaizduoja arkliuką| GamblingGame.Draw |
| drawHorses() | Sukuriam visu arkliuku ir lengtynių trasą, kuri bus naudojama piešimui. | GamblingGame.Draw |
| printMoney() | Piešiam pinigų likutį| GamblingGame.Draw |
| printMoneyWin() | Piešiam pinigų likutį su laimėjimo tekstu| GamblingGame.Draw |
| printMoneyLoose() | Piešiam pinigų likutį su pralaimėjimo tekstu| GamblingGame.Draw |
| drawRace() | Piešiam visu arkliuku ir lengtynių trasą, kuri buvo sukurta iš "drawHorses". | GamblingGame.Draw |
| HorceRaceFont() | Žodynas mūsų piešiniam, kuris integruojasi su interfeisu| GamblingGame.Art |
| JoinLetters() | Skaitom gaunama tekstą ir formatavimą, ir išverčiam kiekvieną simbolį į piešinį iš žodyno, bei sujungiam.| GamblingGame.Art |





## Klasių input ir output  / inferface and return

#### **`Klasė - Program`**

#### SetWindowSize()
```csharp
SetWindowSize(Width, Height)
```
**Nustato konsolės lango dydi**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| Width | konsolės plotis |
| Height | konsolės aukštis |


#### ShowWindow()
```csharp
ShowWindow(Konsolė, int parametras)
```
**Parodo konsolę su nustatytais parametrais**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| konsolė | konsolės objektas |
| parametras | norimas konsolės veiksmas |

#### **`Klasė - Draw`**

#### horse()
```csharp
public static string horse(int distance)

```
**Klasė kuri pavaizduoja arkliuką**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| distance | atstumas per kuri bus judinamas arkliukas |

#### drawHorses()
```csharp
public static string drawHorses(int horse1, int horse2, int horse3, int horse4)

```
**Sukuriam visu arkliuku ir lengtynių trasą, kuri bus naudojama piešimui.**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| horse[X] | atstumas per kuri bus judinamas kiekvienas arkliukas |

#### printMoney()
```csharp
public static string printMoney(int money)

```
**Piešiam pinigų likutį**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| money | pinigu suma kuri bus pavaizduojama |

#### printMoneyWin()
```csharp
public static string printMoneyWin(int money)

```
**Piešiam pinigų likutį su laimėjimo tekstu**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| money | pinigu suma kuri bus pavaizduojama |

#### printMoneyLoose()
```csharp
public static string printMoneyWin(int money)

```
**Piešiam pinigų likutį su pralaimėjimo tekstu**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| money | pinigu suma kuri bus pavaizduojama |

#### drawRace()
```csharp
public static string drawRace(string result)

```
**Piešiam visu arkliuku ir lengtynių trasą, kuri buvo sukurta iš "drawHorses"**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| result | Tektas, kuris laiko trasos ir arkliuku vaizdus |

#### **`Klasė - Art`**

#### class HorceRaceFont : IHorceFontInterface
**Žodynas mūsų piešiniam, kuris integruojasi su interfeisu**

#### drawRace()
```csharp
 public static string JoinLetters<T>(int space, string text)
                            where T : class, IHorceFontInterface, new()

```
**Skaitom gaunama tekstą ir formatavimą, ir išverčiam kiekvieną simbolį į piešinį iš žodyno, bei sujungiam.**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| space | Koks tarpas bus tarp ivestu parametru/piesiniu |
| text | Tekstas, kuris bus dekoduojamas su zodynu|
