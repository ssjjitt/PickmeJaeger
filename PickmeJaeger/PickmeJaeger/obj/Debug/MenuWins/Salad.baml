   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PickmeJaeger.MenuWinsPickmeJaeger.MenuWins  5   	   ?$clr-namespace:PickmeJaeger.ViewModelPickmeJaeger.ViewModel  5   	   !    PickmeJaeger.MenuWins.Salad   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PickmeJaeger.MenuWins     5   	   7local1$clr-namespace:PickmeJaeger.ViewModel     5   	   -   5          �Name$  Saladd��5   	    � Title$ Salad��5	   	   $	��650��5
   	   $	��950��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � DataContext 5      )   #PickmeJaeger.ViewModel.AppViewModel  5   
   .��5      � .+�5   
   �� $��0��6      BackgroundStyleControl#��[  6!   ��5      �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource 5      �� 5      	 �� CacheOption$	 OnLoad=�6&   
 �� CreateOptions$
 IgnoreImageCache=�6;    �� 	UriSource$� �file:///C:/Users/lenovo/AppData/Local/Microsoft/VisualStudio/17.0_db2d7193/Designer/Cache/11277884770x86DD/Assets/Pictures/back.jpg?�6\   5      ._�5      � -   5         �Name$ 	GridSalad��5      $	��950��6&    � RowDefinitions 5       �� 5!      $��2* �6$   �� 5"      $
��0.5* �6$   �� 5#      $	��17* �6$   �� 5$      $
��0.3* �6$    � ColumnDefinitions 5&      �� 5'      $��1* �6'   �� 5(      $	��20* �6'   �� 5)      $��1* �6'   .+�5,      � $��0��6   $��1��6$   .+�5-      ��  	 Salad#���  6      	BlackText#��[ 6?   $	��Top=�6b   $��0 20 0 0q�6z   $��25(�6�   �� 5.        CloseAppStyle#��[ 50      $��
0,10,-20,0q�68   ��5.      �� *CloseAppCommand+��5/      ��  �� ElementName$ Saladd��50   8   51      � 52      $��2��6   $��1��6$   .+�53      �� $��Hidden=�6#   .��54      �� -   5         ��Name$ salad��54   '   
������ $	��829��6O   $��Right=�6[   ��55      �� 56   "   .R�57   &   � 58   #   ��5;      �� 5<   "   .R�5=   &   �� $��10q�6-    �� Padding$ 10q�5>   -   $
��auto��5?   -   ._�5@   *   �� 
������ .+�5A   .   �� $	��225��6Q   $	��225��6]   $��0,0,0,5q�6j   ��64   �� *	DishImage+6j   �� 5B   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68    �� TextAlignment$ Center=�6n   $��14(�6�     WrapText#��[ 6�   $	��225��6�   $��0,0,0,15q�6�   ��6�   �� *
DishName+6�   �� 5C   .    �� Orientation$ 
Horizontal=�69   $��Center=�6R   $��0,0,0,3q�6o   .+�5D   2   �� $.��(/Assets/Fonts/#CormorantGaramond Regular)�6<   $
 Left=�6r   $��14(�6�   #��[ 6�     Weighty#���  6�   $��25��6�   $��0,0,0,0q�6�   �� 5E   2   $.��(/Assets/Fonts/#CormorantGaramond Regular)�6<   $ Right=�6r   $��14(�6�   #��[ 6�   $	��190��6�   $��0 0 0 0q�6�   ��6�   �� *
DishWeight+6�   �� 5F   2   $.��(/Assets/Fonts/#CormorantGaramond Regular)�6<   $
 Left=�6r   $��14(�6�   #��[ 6�    	 Grams#���  6�   $��10��6�   $��0 0 0 0q�6�   5G   /   �� 5H   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68   $
 Left=�6n   $��14(�6�   #��[ 6�    	 Descy#���  6�   $	��225��6�   $��0,0,0,3q�6�   �� 5I   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68   $
 Left=�6n   $��14(�6�   #��[ 6�   $	��225��6�   $
��Auto��6�   ��6�   �� *DishDescription+6�   5J   +   5K   '   5L   #   5N      5O      5P      5Q      5R      5S      5T      