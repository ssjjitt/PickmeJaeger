   M S B A M L   `   `   `  ����G  CPickmeJaeger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PickmeJaeger.ControlsPickmeJaeger.Controls  5      +    %PickmeJaeger.Controls.RegisterControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PickmeJaeger.Controls     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al	 hMahApps.Metro.IconPacks.PhosphorIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.GameIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^ ZMahApps.Metro.IconPacks, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Coolicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.MemoryIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae  aMahApps.Metro.IconPacks.Lucide, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am! iMahApps.Metro.IconPacks.MaterialDesign, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.Fontisto, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae# aMahApps.Metro.IconPacks.Modern, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag$ cMahApps.Metro.IconPacks.EvaIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.CircumIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai& eMahApps.Metro.IconPacks.RPGAwesome, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah' dMahApps.Metro.IconPacks.Fontaudio, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah( dMahApps.Metro.IconPacks.RemixIcon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af) bMahApps.Metro.IconPacks.Microns, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai* eMahApps.Metro.IconPacks.RadixIcons, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a�	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks&     	 
                        ! " # $ % & ' ( ) * 69   .��5      � ��5   
   �� 5        �� ImageSource$  /Assets/Pictures/back.jpg��6    j� Stretch$ UniformToFill=�6A    j� TileMode$
 None=�6Y    j� ViewportUnits$ RelativeToBoundingBox=�6i    j� Viewport$ 0,0,1,1�6�   .+�5   
   � $	��380��6   $	��450��6   $��Center=�6(   $��Center=�6C   .+�5      �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��2��6   ��5      �� 5      .��5      �  � Color$ 	#66142227��6+    � Offset$	 0.0Q�6=   � 5      $ 	#66121212��6+   $	 0.7Q�6=   5      5      �� 5      -   5           CloseAppStyle#��[  5      $��0q�6U   �� 5       $��Center=�6   .+�5!      �� $!��/Assets/Pictures/Jaeger.png��6   $	��235��6A   $	��204��6M   �� 5"        Register#���  6    $��Light"�5#      $&�� Fonts/#CormorantGaramond Regular)�5$      $��22(�5%      
�������$��Center=�5'      $��0,8,0,0q�69   $��32��6J   $	��124��6V   5)      �� 5+      $��1��6   .+�5,      ��  �� Orientation$ 
Horizontal=�6!   .+�5-      �� -   5        	 ��Name$	 
loginField��5-   "   $&�� Fonts/#CormorantGaramond Regular)�5.      $��Light"�5/      $��20(�50      $��Center=�51      
�������
������ $��0q�54      $	��235��55      $
��Left=�56      
 J� Opacity$	
 0.5Q�57      $��25��58      $��63,0,0,0q�59      �� 5:       	 Login#���  6$    J� IsHitTestVisible .  $��-230,0,-5,0q�5<       $&�� Fonts/#CormorantGaramond Regular)�5=       $��Light"�5>       $��20(�5?       $��Center=�5@       
�������
������ $	��235��5C       $	
 0.5Q�5D       $��25��5E       ��5F      �� 5G   "    �� 
TargetType" ��6(   .�5H   &   ��  �� Property � y� �� Value$ 	Collapsed=�6C    �� Triggers 5I   &   �� 5J   *    �� Binding 66   �� *Text+ �� ElementName$ 
loginField�� �� Value  6g   .a�5K   .   ��  � y�$ Visible=�6K   5L   +   5O   #   5Q      . 
 (MahApps.Metro.IconPacks.PackIconMaterial  5R         Kind$ 
AccountBox=�65   $��Center=�5S   1   $��Center=�5T   1   
�������5U   1   5V      �� 5W      $	��250��6   $��2��5X      
�������$	
 0.5Q�5Z      �� 5\      $ 
Horizontal=�6!   $��0,5,0,0q�6:   .+�5]      G� -   5         G�Name$ 
passField1��5]   &    G� Password$ password��5^      $&�� Fonts/#CormorantGaramond Regular)�5_      $��Light"�5`      $��20(�5a      $��Center=�5b      
�������
������ $��0q�5e      $	��235��5f      $
��Left=�5g      $	
 0.5Q�5h      $��25��5i      $��63,0,0,0q�5j        5l      $	 Key=�65   $��Center=�5m   1   $��Center=�5n   1   
�������5o   1   5p      �� 5q      $	��250��6   $��2��5r      
�������$	
 0.5Q�5t      �� 5v      $ 
Horizontal=�6!   $��0,5,0,0q�6:   .+�5w      G� -   5        $ 
passField2��5w   &   $ password��5x      $&�� Fonts/#CormorantGaramond Regular)�5y      $��Light"�5z      $��20(�5{      $��Center=�5|      
�������
������ $��0q�5      $	��235��5�      $
��Left=�5�      $	
 0.5Q�5�      $��25��5�      $��63,0,0,0q�5�      �� 5�      $%��Повторите пароль��6$    .  $��-230,0,-5,0q�5�       $&�� Fonts/#CormorantGaramond Regular)�5�       $��Light"�5�       $��20(�5�       $��Center=�5�       
�������
������ $	��235��5�       $	
 0.5Q�5�       $��25��5�       ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � y�$ 	Collapsed=�6C    5�   &   �� 5�   *    66   �� *Text+$ 
passField2��  6g   .a�5�   .   ��  � y�$ Visible=�6K   5�   +   5�   #   5�        5�      $	 Key=�65   $��Center=�5�   1   $��Center=�5�   1   
�������5�   1   5�      �� 5�      $	��250��6   $��2��5�      
�������$	
 0.5Q�5�      �� 5�      $ 
Horizontal=�6!   $��0,50,0,0q�6:   .+�5�      �� -   5        $	��120��5�   !   $��40��6-     Back#���  69   $��	60,0,20,0q�6m   $��15(�6�   $
��Thin"�6�   �� 5�      -   5        $	��120��5�   !   $��40��6-     Registration#���  69   $��15(�6y   $
��Thin"�6�   5�      5�      5�      5�      5�      5�      