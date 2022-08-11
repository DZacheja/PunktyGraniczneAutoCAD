# PunktyGraniczneAutoCAD
Wczytywanie punktów granicznych z atrybutami do programu AutoCAD. <br>
Rozszerzenie wyróżnia fakt, że wczytane punkty posiadają następujące atrybuty:
* <b>Numer</b>
* <b>BPP</b> (Błąd średni położenia punktu granicznego względem osnowy geodezyjnej 1 klasy)
* <b>STB</b> (Kod stabilizacji punktu granicznego )
* <b>ZRD/SPD</b> (Sposób pozyskania danych o punkcie granicznym) 
* <b>RZG</b> (Kod rzedu granicy) - Obecnie niefunkcjonuje, jednak wiele ośrodków wciąż wydaje dane z tym atrybutem
* Plik - nazwa pliku z jakiego zostały wczytanie dane

## Prezentacja graficzna punktów

Zgodnie z rozporządzeniem:<br>
<i>ROZPORZĄDZENIE MINISTRA ROZWOJU, PRACY I TECHNOLOGII z dnia 23 lipca 2021 r. w sprawie bazy danych obiektów topograficznych oraz mapy zasadniczej</i>
<br>link: https://isap.sejm.gov.pl/isap.nsf/download.xsp/WDU20210001385/O/D20211385.pdf<br>
Punkty rozróżnione zostały jako stabilizowane oraz niestabilizowane.<br><br>
<p align="center">
<img src="Images/Wczytane punkty.png" Height=400>
</p>
<br>

## Okno do wczytywania punktów

Do wczytania współrzędnych zostało utworzone intuicyjne okno:<br>
Po wczytaniu programu do AutoCAD okno wywołuje się komendą PUNKTYGRANICZNE -> WCZYTAJ
<br><br>
<p align="center">
<img src="Images/Menu wczytywanie.png" Height=400>
</p>

## Selekcja wczytanych punktów
Program umożliwia za pomocą intuicyjnego okna seleckji zaznaczyć lub przenieść/skopiować na warstwę punkty.
Okno seleckji uruchamia się wpisując w wiersz poleceń następujące komendy: PUNKTYGRANICZNE -> SELECKJA

<p align="center">
<img src="Images/Menu wybór.png" Height=400>
</p>

### Autor programu:
<b>Damian Zacheja</b> <br>
Licencja:<b>
  <b>[MIT](https://github.com/DZacheja/PunktyGraniczneAutoCAD/blob/master/LICENSE)<b>
