   M S B A M L   `   `   `  ����R  NSzyfr_z_linią_łamaną, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Szyfr_z_linią_łamanąSzyfr_z_linią_łamaną  5   	   /    )Szyfr_z_linią_łamaną.Zasada_działania   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Szyfr_z_linią_łamaną     5   	     � Title$  Zasada_działania��5   	   $��386.098��6"   $��881.374��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ textBox��5      $
��Left=�6#   $��22��6>   $��	10,70,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��292��6�   �� 5   
   -   5         ��Name$ button��5      $��Start��6!   $
��Left=�61   $��
88,114,0,0q�6L   $	��Top=�6`   $��76��6x   6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��22��6?   $��
338,70,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $��46��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgData��5      $
��Left=�6#   $	��148��6>   $��
10,138,0,0q�6K   $	��Top=�6_   $	��374��6w   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��22��6?   $��
10,322,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��294��6�   �� 5   
   -   5        $ button1��5      $��Pokaż��6"   $
��Left=�62   $��308,324,0,0q�6M   $	��Top=�6b   $��76��6z   6�   �� 5   
   -   5         ��Name$ label��5      $��
Szyfrogram��6   $
��Left=�64   $��
10,296,0,0q�6O   $	��Top=�6c    J� RenderTransformOrigin$ -12.671,2.115&�6{   $	��148��6�   �� 5   
   -   5        $ label1��5      $��Wizualizacja��6    $
��Left=�67   $��
10,108,0,0q�6R   $	��Top=�6f   �� 5   
   -	   5        $ label2��5      $��Tekst jawny��6    $
��Left=�66   $��	10,48,0,0q�6Q   $	��Top=�6d   $ 	-11.961,3&�6|   $	��222��6�   �� 5   
   -
   5        $ label3��5      $��Klucz��6    $
��Left=�60   $��
338,48,0,0q�6K   $	��Top=�6_   $ 	-4.145,-3&�6w   �� 5   
   -   5        $ label4��5      $����Szyfr z linią łamaną jest to szyfrem przestawieniowym. 
Jego działanie polega na zapisaniu tekstu jawnego w 
formie zygzaka o określonej wysokości. 
Kluczem w szyfrze jest wysokość "zygzaka", po którym
rozstawia się litery. Kluczem może być liczba naturalna 
większa od 1. 
Szyfrogram powstaje poprzez odczytywanie kolejnych liter 
z zygzaka wiersz po wierszu zaczynając od wiersza górnego.

Przykład:
Tekst jawny:   Zielone jabłuszko!          Klucz:  5

Szyfrogram:   oulnłseebzi ak!Zjo��6    $
��Left=�6f  $	��322��6�  $��
422,22,0,0q�6�  $	��Top=�6�  $	��442��6�  $��16(�6�  �� 5   
   -   5        $ label5��5      $��Szyfr z linią łamaną��6    $
��Left=�6?   $��	12,10,0,0q�6Z   $	��Top=�6m   $	��316��6�   $��20(�6�   5      5      