   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PickmeJaegerPickmeJaeger  5   	       PickmeJaeger.Message   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PickmeJaeger     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MessageBox��5	   	   $	��200��5
   	   $	��300��5   	   $��Center=�5   	   $��Center=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��2��6   ��5      �� 5       �� ImageSource$ /Assets/Pictures/back.jpg��6    j� Stretch$ UniformToFill=�6E   5      �� 5   
   $��Hidden=�6   .��5      �� -   5        $��MessageContainer��5   h   $%��Fonts/CormorantGaramond Regular)�6   
�������$
��18px(�6X   $��WrapWithOverflow=�6�   $��15q�6�   $��Center=�6�   $��Center=�6�   5       �� 5"   
   -   5        $��ButtonContainer��5"      $��1��6,    �� Orientation$ 
Horizontal=�69   $��Right=�5#      $��10q�61    � 	Resources 5$      	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value��%�  '��       �� 5%      "	 ��6   .�5'      �� 
 � ��$
 auto��6/   �� 5(      
 � ��$ 75��61   �� 5)      
 � ��
 �����63   �� 5*      
 � ��$ 14(�61   �� 5+      
 � ��$' !/Fonts/#CormorantGaramond Regular)�63   �� 5,      
 � ��
 ���� 63   �� 5-      
 � �� 5.      �� 5/      " ��6.   .R�50   "   �� #��z��6)   $ 10��51      $��2q�52      
�������._�54   &   �� $��Center=�67   $��Center=�6T   55   #   56      58       5:      P� 5;       �@J�IsMouseOver . . �5<      �� 
 � ��
 �����6;   �� 5=      
 �@J�Opacity$	 0.4Q�68   �� 5>      
 � ��
 ��� �6;   5?      5B      5C      5D      5E      5F      