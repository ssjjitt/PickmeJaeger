   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PickmeJaeger.ControlsForUserPickmeJaeger.ControlsForUser  5      ?$clr-namespace:PickmeJaeger.ViewModelPickmeJaeger.ViewModel  6G   -    'PickmeJaeger.ControlsForUser.SearchMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:PickmeJaeger.ControlsForUser     5      :	viewmodel$clr-namespace:PickmeJaeger.ViewModel     6G   -   5          >�Name$  Search��5
      $��Center=�5	      .��5      � .+�5   
   �� $��0��6      BackgroundStyleControl#��[  6!   ��5      �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource 5      �� 5       �� CacheOption$ OnLoad=�6&    �� CreateOptions$ IgnoreImageCache=�6;    �� 	UriSource$� �file:///C:/Users/lenovo/AppData/Local/Microsoft/VisualStudio/17.0_db2d7193/Designer/Cache/11277884770x86DD/Assets/Pictures/back.jpg?�6\   5      ._�5      � -   5         �Name$ GridMenu��5      $	��950��6%    � RowDefinitions 5      �� 5      $	��51* �6$   �� 5      $	��76* �6$   �� 5      $
��293* �6$   �� 5      $	��30* �6$    � ColumnDefinitions 5      �� 5      $	��43* �6'   �� 5      $
��355* �6'   �� 5      $
��509* �6'   �� 5       $	��43* �6'   .+�5$      � $��0��6   $��4��6$   $��	13,0,36,0q�68   .+�5%      ��  
 Search#���  6      	BlackText#��[ 6@   $	��Top=�6c   $��Center=�6{   $��0 20 0 0q�6�   $��25(�6�   5&      �� 5)      $��1��6   $��2��6*   	 �� Orientation$	 Vertical=�6:   $��0,0,0,1q�6Q   .+�5-      �� $	 
Horizontal=�6!   $��5,5,5,5q�6:   .+�5.      �� $��Цена от:��6$   $��Center=�64   
�������$��0,0,5,0q�6b   �� 5/      -   5        $��PriceFromTextBox��5/   "   $��70��6:   $��25��6E   $��5q�6Q   ���	#FFC8D6FF
���������6\   Z� ��6�   �� *	PriceFrom+
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 50      $��до:��6$   $��Center=�6/   
�������$��0,0,5,0q�6]   �� 51      -   5        $��PriceToTextBox��51   "   $��70��68   $��25��6C   $��5q�6O   ���	#FFC8D6FF
���������6Z   Z� ��6�   �� *	PriceTo+$
 PropertyChanged=�6�   �� 52      $��Вес от:��6$   $��Center=�63   
�������$��0,0,5,0q�6a   �� 53      -   5        $��WeightFromTextBox��53   "   $��70��6;   $��25��6F   $��5q�6R   ���	#FFC8D6FF
���������6u   Z� ��6�   �� *
WeightFrom+$
 PropertyChanged=�6�   �� 54      $��до:��6$   $��Center=�6/   
�������$��0,0,5,0q�6]   �� 55      -   5        $��WeightToTextBox��55   "   $��70��69   $��25��6D   $��5q�6P   ���	#FFC8D6FF
���������6s   Z� ��6�   �� *
WeightTo+$
 PropertyChanged=�6�   �� 57      -   5        $��ResetButton��57   G     EmptyButton#��[ 6!   $��31��6Z   $��30��6e   $��10,0,0,0q�6q   ��58      �� 59   "   $! /Assets/Pictures/reload.png��6-   5;      5<      �� 5=      -   5         ��Name$ ApplyButton��5=   1   $��Применить��6   $��90��6F   $��30��6Q   6]   5>      �� 5A      $��1��6   $	 Vertical=�6*   $��1��6A   $��0,0,10,0q�6Q   .+�5C      �� $	 
Horizontal=�6!   $��0,0,0,10q�6:   .+�5D      �� -	   5         ��Name$ SearchTextBox��5D   :   $	��300��6"   $��30��6.   $
��Left=�6Q   $��0,0,10,0q�6l   �� 5E      -
   5        #��[ 5E   !   $��30��6F   $��30��6Q   ��5F      �� 5G   "   $
 Fill=�6-   $! /Assets/Pictures/search.png��6<   5I      5J      �� 5L      .+�5M      �� -   5         ��Name$ TypeComboBox��5M   #   $	��180��5N      $��30��5O      ���	#FFC8D6FF��5Q      �� *	DishTypes+ �� SelectedItem 5R      �� *SelectedType+$
 PropertyChanged=�5S      5U      5V      � 5Z      $��2��6   $��2��6$   $��0,2,0,0q�68   $��1��6I   .+�5[      �� $��Hidden=�6#   .��5\      �� -   5         ��Name$ MenuItemsControl��5\   '   
������ $
��Auto��6Z   ��5]      �� 5^   "   .R�5_   &   � 5`   #   ��5c      �� 5d   "   .R�5e   &   �� $��10q�6-    �� Padding$ 10q�69   $
��auto��6F   ._�5f   *   �� 
������ .+�5g   .   �� $	��225��6Q   $	��225��6]   $��0,0,0,5q�6j   ��64   �� *	DishImage+6j   �� 5h   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68    �� TextAlignment$ Center=�6n   $��14(�6�     WrapText#��[ 6�   $	��225��6�   $��0,0,0,15q�6�   ��6�   �� *
DishName+6�   �� 5i   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68   $
 Left=�6n   $��14(�6�   #��[ 6�   $	��225��6�   $��0,0,0,3q�6�   ��6�   �� *
DishType+6�   �� 5j   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68   $
 Left=�6n   $��14(�6�   #��[ 6�   $	��225��6�   $
��Auto��6�   ��6�   �� *DishDescription+6�   �� 5k   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68   $
 Left=�6n   $��14(�6�   #��[ 6�   $	��225��6�   $
��Auto��6�   ��6�   �� *
DishWeight+6�   �� 5l   .   $.��(/Assets/Fonts/#CormorantGaramond Regular)�68   $
 Left=�6n   $��14(�6�   #��[ 6�   $	��225��6�   $
��Auto��6�   ��6�   �� *	DishPrice+6�   5m   +   5n   '   5o   #   5q      5r      5s      � 5u      $��3��6   $��2��6$   $��1��68   .+�5v      �� $	 
Horizontal=�6!   $��Center=�6:   $��Center=�6W   .+�5w      �� -   5        #���  5w   !   $��50��6G   $
��Auto��6R   $��0q�6`   {�6�   �� *CanGoPrevious+��5x      �� 5y   "   $$ /Assets/Pictures/arrowback.png��6-   5{      �� 5|      $��Center=�6E   $��	10,0,10,0q�6`   
�������$��16(�6�   $��58��6�   ��6$   �� *CurrentPageText+6�   �� 5}      -   5        #���  5}   !   $��50��6G   $
��Auto��6R   $��0q�6`   {�6�   �� *	CanGoNext+��5~      �� 5   "   $' !/Assets/Pictures/arrowforward.png��6-   5�      5�      5�      5�      5�      5�      5�      