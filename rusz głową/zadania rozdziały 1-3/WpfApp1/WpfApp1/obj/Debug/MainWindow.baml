   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ button1��5      $��Pokaż komunikat��6"   $��Center=�6<   6Y   �� 5   
   -   5        $ button2��5      $��if/else��6"   $��Center=�64   $��1��6Q   6a   �� 5   
   -   5        $ button3��5      $#��Sprawdzenie kolejnego warunku��6"   $��Center=�6J   $��1��6g   6t   �� 5   
   -   5        $ button4��5      $��Pętla��6"   $��Center=�62   $��1��6O   $��1��6_   6l   �� 5   
   -   5         ��Name$ myLabel��5      $��Center=�6%   $��Center=�6B   $��2��6]   $��2��6j   5      5       