   M S B A M L   `   `   `  ����F  BDiseñoTres, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DiseñoTresDiseñoTres  5   	       DiseñoTres.Usuario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DiseñoTres     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Polyuprotec��5	   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � WindowState$ 	Maximized=�6[   .��5      � ���	#FFFFDBDB � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�6#   $��2��66   $��Stretch=�6J   .��5      � .+�5      �� $��0,9,55,0q�6   $	��311��6/   $��Right=�6;   .+�5      � .+�5      �� 
�������$��	25 0 25 0q�69   �� 5      $��Right=�6!      MaterialDesignFlatButton#��[  6=   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�66   5      5      5       '  !MaterialDesignThemes.Wpf.PopupBox  5!      $��Right=�6*   $��10q�6F      PlacementMode$ BottomAndAlignRightEdges=�6R      	StaysOpen .  	   PopupContent.	 5"      �� $	��150��6!   .+�5#      �� $��Configuraciones��6!   �� 5$      $��ayuda��6!   �� 5%      $��sobre nosotros��6!   �� 5&      �� 5'      -   5        
 ��Name$
 ButtonPopUpLogout��5'   !   $��Logout��6<   6M   5(      5)      5*      5+      � 5-   
   $��Stretch=�6   $��1��6-     PrimaryHueDarkBrush#��[ 6:    5.      �� 5/      $��70 �6    �� 50      $	��326 �6    .+�52      � $��0��6   
�������.+�53      �� $��Assets/Logo-poly.png��6   54      56      �� 57   
   $��Stretch=�6   $��Disabled=�65   $
��Auto=�6^   $��1��6�   .��58      �� $
��0 75q�6   .+�59      �� -   5        $��Center=�59      $	��210��66   .��6W   
Carpetas6a   5;      5<      �� 5=   
   -   5         ��Name$ StackPanelMain��5=      $��1��6-   $��1��6:   $��Stretch=�6J    � 5>   
   -   5          �Name$ 	MainFrame��5>      6%   5?      5@      