   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PickmeJaegerPickmeJaeger  5   	   ?$clr-namespace:PickmeJaeger.ViewModelPickmeJaeger.ViewModel  5   	   !    PickmeJaeger.WindowForAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PickmeJaeger     5   	   7local1$clr-namespace:PickmeJaeger.ViewModel     5   	   -   5          �Name$  	AppWindow��5
   	    � Title$ WindowForAdmin��5	   	   $	��650��5   	   $	��950��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������  � DataContext 5      )   #PickmeJaeger.ViewModel.AppViewModel  5   
    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      .��5      �  � ColumnDefinitions 5    
   �� 5!      $
��100* �6   �� 5"      $��0* �6   .+�5&   
   �� $��0��6     BackgroundStyle#��[ 6!   ._�5'      � -   5         �Name$ MainGrid��5'      $	��950��6%   .+�5(      �� $��/Assets/Pictures/back.jpg��6   $��UniformToFill=�5)      � 5-        NameBase#��[ 6   $��0,0,0,0q�69   $	��700��6J   $��Center=�6V   $��Center=�6s   $	��200��6�   .+�5.      ��   TextOne#��[ 6    $��PICKME, JAEGER!��6A   $��86(�6X   $	��700��6f   $��Center=�6r   $��Center=�6�   $
��Bold"�6�   �� 5/      $��5��50      
�������	 J� Opacity$	 1Q�52      $��227,147,227,48q�6   �� 53        
TextBorder#��[ 6   
�������$��43��6T   $��	0,157,0,0q�6`   $	��Top=�6s   $	��382��6�   ._�54      ��   TextTwo#��[ 6$    
 Textic#���  6E   $��28(�6e   $
��Bold"�6s   55      56      57      58      �� 5;   
     MenuBtnStyle#��[ 5<      ��5;      �� *ShowPanelCommand+5<      �� 5>   
     CloseAppStyle#��[ 5@      ��5>      �� *CloseAppCommand+��5?      �� 
 �� ElementName$
 	AppWindow��5@      �� 5D   
    	 
PanelStyle#��[	 6   y�65   �� *IsPanelVisible+ �� 	Converter# [  ._�5E      � .+�5G      ��  
 ClosePanelStyle#��[
 6>   ��6   �� *HidePanelCommand+6>   �� 5J      -   5         ��Name$ LV��5J      
������ 
������ $��Disabled=�5M      $	��350��5O      $	��250��5P      .@�5T      �� $
��Left=�6#   $��0,0,0,10q�5U   #   $	��250��5V   #   $��70��5W   #   .��5Y      ��  �� Orientation$ 
Horizontal=�6%   $	��250��5Z   %   .+�5\      �� $��/Assets/Pictures/home.png��6$   $��50��5]   $   $��50��5^   $   $��12,0,0,0q�5_   $   �� 5a        Home#���  6(     	BlackText#��[ 6F   $��27,0,0,0q�6i   $��18(�6{   5b      5c      �� 5g      $
��Left=�6$   $��70��6F   $	��250��6R   $��0,0,0,10q�6^   .��5i      �� $ 
Horizontal=�6%   $	��250��5j   %   .+�5l      �� $��Assets/Pictures/menu.png��6$   $��50��5m   $   $��50��5n   $   $��12,0,0,0q�5o   $   �� 5q        Menu#���  6(   #��[ 6F   $��25,0,0,0q�6i   $��18(�6{   $��Center=�6�   5r      5s      �� 5w      $
��Left=�6#   $��0,0,0,10q�5x   #   $	��250��65   $��70��6A   .��5z      �� $ 
Horizontal=�6%   $	��250��5{   %   .+�5}      �� $ ��Assets/Pictures/orders.png��6$   $��50��5~   $   $��50��5   $   $��12,0,0,0q�5�   $   �� 5�       
 Orders#���  6(   #��[ 6H   $��25,0,0,0q�6k   $��18(�6}   5�      5�      �� 5�      $
��Left=�6#   $��0,0,0,10q�6E   $	��250��6W   $��70��6c   .��5�      �� $ 
Horizontal=�6%   $	��250��6>   .+�5�      �� $��Assets/Pictures/user.png��6$   $��50��6F   $��50��6Q   $��12,0,0,0q�6]   �� 5�       	 Users#���  6(   #��[ 6G   $��25,0,0,0q�6j   $��18(�6|   5�      5�      5�      �� 5�        	ChangeLan#���  6   $��Bottom=�6?   $��50,0,0.604,136.139q�6Z   $$��16                            (�6v   
�������5�      �� 5�      -   5        $��menuLanguage��5�      $��30��6/   $��24,522,25.604,93.139q�6;   $	��150��6Y   6g   5�      5�      5�      5�      