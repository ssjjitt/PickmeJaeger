   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PickmeJaeger.ControlsPickmeJaeger.Controls  5      '    !PickmeJaeger.Controls.MenuControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PickmeJaeger.Controls     5      -   5          >�Name$
  Menu��5
      $��Center=�5	       � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%,  '        '  v     �� 5   
   "  6   .�5      ��  � �� �	#992727276+   �� 5       � ��
 �����6+   5      �� 5   
   "  6   .�5      ��  � �� �	#992727276+   �� 5       � ��
 �����6+   �� 5       � �� �	#992727276,   5      5      .��5      � .+�5   
   �� $��0��6      BackgroundStyleControl#��[  6!   ��5      �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource 5      �� 5       �� CacheOption$ OnLoad=�6&    �� CreateOptions$ IgnoreImageCache=�6;   	 �� 	UriSource$�	 �file:///C:/Users/lenovo/AppData/Local/Microsoft/VisualStudio/17.0_db2d7193/Designer/Cache/11277884770x86DD/Assets/Pictures/back.jpg?�6\   5       ._�5#      � -   5        
 �Name$
 MainGrid��5#      $	��950��6%    � ColumnDefinitions 5%      �� 5&      $��1* �6'   �� 5'      $	��30* �6'   �� 5(      $��1* �6'    � RowDefinitions 5*      �� 5+      $
��0.9* �6$   �� 5,      $��8* �6$   �� 5-      $
��0.1* �6$   .+�50      � $��1��6   $��1��6$   .+�51      �  52      �� 53      $	��10* �6,   �� 54      $��1* �6,   .+�56      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGridMenu��56   h      AutoGenerateColumns .     
IsReadOnly . ���	#99272727"   VerticalScrollBarVisibility$ Hidden=�6{   $   HorizontalScrollBarVisibility$ Hidden=�6�   $��0,5,0,0q�6�    58      )  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value��%  '        �� 59   "   "  6(   .�5:   &   ��  � �� �	#992727276C   �� 5;   &    � ��
 �����6C    5<   &   P� 5=   *    �@ 
IsSelected . . �5>   .   ��  � �� �	#FFA7BBF96K   �� 5?   .    � ��
 �����6K   5@   +   5B   #   5C         Columns 5E      4  .System.Windows.Controls.DataGridTemplateColumn  5F   "     Picture,  &System.Windows.Controls.DataGridColumn   Header# �  69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6\      CellTemplate 5G   &   �� 5H   *   .R�5I   .   �� $	��150��64   $	��150��6A   ��6M   �� *	DishImage+5J   +   5L   #   0  *System.Windows.Controls.DataGridTextColumn  5M   "     WrapText1	  +System.Windows.Controls.DataGridBoundColumn 	  ElementStyle# [ 65     Dish# �  6^   $	 150 6�    	  Binding 6~   �� *
DishName+6�     5N   "   # [ 65     Type# �  6^   $	 100 6�    6~   �� *
DishType+6�     5O   "   # [ 65    	 Price# �  6^   $	 100 6�    6   �� *	DishPrice+6�     5P   "   # [ 65    
 Weight# �  6^   $	 100 6�    6�   �� *
DishWeight+6�     5Q   "   # [ 65     Desc# �  6^   $	 283 6�    6~   �� *DishDescription+6�   5S      �� 5T      -   5         ��Name$ BtnAdd��5T   �     UsualButton#��[ 6!   $��90��6F   $��30��6Q   $��680,13,0,10q�6]    	 Add#��� 	 6r   $��1��6�   $
��Left=�6�   6�   �� 5U      -   5        $ 	BtnDelete��5U   �   #��[ 6!   $��90��6F   $��30��6Q   $��791,13,0,10q�6]    

 Delete#��� 
 6r   $��1��6�   $
��Left=�6�   6�   5V      5W      5X      5Y      5Z      5[      