   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PickmeJaeger.WindowsPickmeJaeger.Windows  5   	   %    PickmeJaeger.Windows.AddComment   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PickmeJaeger.Windows     5   	   -   5          �Name$  Comment��5   	    � Title$ 
AddComment��5   	   $	��400��5	   	   $	��300��5
   	   $��Center=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �� $��0��6      BackgroundStyleControl#��[  6!   ��5      �� 5       j� Stretch$ UniformToFill=�6    �� ImageSource 5      �� 5       �� CacheOption$ OnLoad=�6&   	 �� CreateOptions$	 IgnoreImageCache=�6;   
 �� 	UriSource$�
 �file:///C:/Users/lenovo/AppData/Local/Microsoft/VisualStudio/17.0_db2d7193/Designer/Cache/11277884770x86DD/Assets/Pictures/back.jpg?�6\   5      ._�5      �  � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      $	��20* �6'   �� 5      $��1* �6'    � RowDefinitions 5!      �� 5"      $��1* �6$   �� 5#      $	��13* �6$   �� 5$      $	��10* �6$   �� 5%      $��1* �6$   .+�5'      � $��1��6   $��1��6$   .+�5(      ��   	BlackText#��[ 6      
Impression#���  6C   $��Center=�6g   $��40��6�   $	��250��6�   $
��Wrap=�6�   $	��Top=�6�   $��18(�6�   �� 5)      -   5         ��Name$ 
imgDynamic��5)      $	��120��60   $	��120��6<   $
��Left=�6I   $��	10,10,0,0q�6d   �� 5*      -   5          UploadPhoto#���  5*      $	��130��6E   $��25��6Q     UsualButton#��[ 6]   $��Bottom=�6�   $
��Left=�6�   $��10,0,0,0q�6�   6�   5+      � 5,      $��2��6   $��1��6$   .+�5-      �� -   5         ��Name$	 box��5-   :   $	��120��6G   $	��260��6T   $��Bottom=�6`    �� TextWrapping$
 Wrap=�6{   $��0,0,0,29.545q�6�   $��2��6�   ��6   �� *
ReviewText+6�   �� 5.      -   5          Send#���  5.      #��[ 6>   $	��100��6c   $��25��6o   $��Bottom=�6{   $��Right=�6�   $��1��6�   $��0,0,10,0q�6�   �� 5/      -   5          Back#���  5/      #��[ 6>   $	��100��6c   $��25��6o   $��Bottom=�6{   $
��Left=�6�   $��1��6�   $��10,0,0,0q�6�   50      51      52      53      54      