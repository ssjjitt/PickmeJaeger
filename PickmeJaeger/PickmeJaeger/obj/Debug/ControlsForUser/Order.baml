   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PickmeJaeger.ControlsForUserPickmeJaeger.ControlsForUser  5      (    "PickmeJaeger.ControlsForUser.Order   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:PickmeJaeger.ControlsForUser     5      X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6G   -   5          >�Name$  CartControl��5
      $��Center=�5	      .��5      � .+�5   
   �� $��0��6      BackgroundStyleControl#��[  6!   ��5      �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource 5      �� 5       �� CacheOption$ OnLoad=�6&    �� CreateOptions$ IgnoreImageCache=�6;    �� 	UriSource$� �file:///C:/Users/lenovo/AppData/Local/Microsoft/VisualStudio/17.0_db2d7193/Designer/Cache/11277884770x86DD/Assets/Pictures/back.jpg?�6\   5      ._�5      � -   5         �Name$ GridCart��5      $	��950��6%    � RowDefinitions 5      �� 5      $
��0.5* �6$   �� 5      $��1* �6$   �� 5      $	��10* �6$   �� 5      $
��0.5* �6$    � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      $	��10* �6'   �� 5      $��1* �6'   .+�5       � $��1��6   $��1��6$   .+�5!      ��   	BlackText#��[ 6      	MakeOrder#���  6C   $��30(�6f   5"      � 5#      $��2��6   $��1��6$   .+�5$      �� .+�5%      �� #��[ 6$     
EnterEmail#���  6G   $
��Left=�6k   $	��Top=�6�   $��8,60,8,8q�6�   $��20(�6�   �� 5&      -   5        	 ��Name$	 Email��5&   "   
 �� TextWrapping$

 Wrap=�61   $��8q�6E   $	��200��6P   $
��Left=�6\   �� 5'      #��[ 6$    
 Wishes#���  6G   $
��Left=�6g   $	��Top=�6�   $��8q�6�   $��20(�6�   �� 5(      -   5        $	 Wishes��5(   "   $

 Wrap=�62   $��8q�6F   $	��150��6Q   �� 5)      #��[ 6$     
ChooseDate#���  6G   $
��Left=�6k   $	��Top=�6�   $��8q�6�   $��20(�6�   "  Xceed.Wpf.Toolkit.TimePicker  5*      -   5          Name$ Picker��5*   *   $
��Left=�6:      MaxDropDownHeight$ 20Q�6U   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Maximum$ 
2024-12-31X�6l      	StartTime$ 8:0:0h�6�      TimeInterval$ 1:0:0h�6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ FullDateTime=�6�   $��8q�6�   $	��300��6�      EndTime$ 22:0:0h�6�   �� 5+      -   5         ��Name$ b1��5+   !   $	��170��6-   $��40��69     
madeChoice#���  6E     UsualButton#��[ 6l   $��Center=�6�   $��0,50,0,0q�6�   $��3q�6�   $��18(�6�   $��Bottom=�6�   5,      5.      5/      50      51      52      