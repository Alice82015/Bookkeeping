   M S B A M L   `   `   `  ����C  ?todolist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:todolisttodolist  5   	       todolist.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:todolist     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��400��6)   ���	#FFC9FFC9.��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      6   �� 5      $��80 �6   6*   .+�5   
   �� $
��Auto=�6   $��1��6:   .��5      �� -   5         ��Name$ TotoItemList��5      61   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��2��6/   ���	#FFFFD1D9.+�5      �� -   5        $ 	TodoStack��5      6.   �� 5      -   5         ��Name$ AddBtn��5   )   $��
30 20 0 20q�6   $��32(�6N   ���	#FFFFD1D9
���Gc��
������ .��6�   +6�   �� 5      $ Vertical=�6   .+�5      �� $��70��6   $��	230 5 0 0q�6'   ���	#FFFFD1D9
���Gc��$��17(�6e   $
��Bold"�6s   	總支出6�   �� 5      $��0 0 30 0q�6   $��Right=�6.   ���	#FFFFD1D9
���E��$��30(�6z   $
��Bold"�6�   06�   5      5      5"      5#      