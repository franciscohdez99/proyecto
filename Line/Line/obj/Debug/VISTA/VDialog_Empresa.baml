   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	        Line.VISTA.VDialog_Empresa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  VDialog_Empresa��5	   	   $	��455��5
   	   $	��800��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   ���	#FF1368BD.��5      � .+�5   
   � -   5        $��myGrids��5      ���	#FF1368BD � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��50 �6    6.   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��Registro de empresas��6   ���#FFF$��14(�6I   $
��Bold"�6W   $��10 10 10 10q�6i   6�   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	btnCerrar��5      $��30��6,   $��30��67   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6C   $��0q�6t   $��5 5 5 5q�6�   
���  ����6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowClose=�6.   $��Right=�6A   5      5       5!      � 5"   
   -   5        $��myGrid��5"      $��0 50 0 0q�6   
�������$	��392��6F    5$      �� 5%      $��* �6#   �� 5&      $��* �6#    5)      �� 5*      $��50 �6    �� 5+      $��50 �6    �� 5,      $��50 �6    �� 5-      $��50 �6    �� 5.      $��50 �6    �� 5/      $��50 �6    �� 50      $��50 �6    �� 51      $��50 �6    .+�58        $	 CityVariant=�6&   $��Bottom=�6t   $
��10 4q�6�   $��0��6�   $��0��6�   ��69   �� 
 �� ElementName$
 txtId�� �� Path$ BorderBrush�6�   �� 59      -   5         ��Name$ txtId��59      $��0��6%   $��0��65   $	��300��6B   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
ID Empresa��6N   $	��0 6q�6z      
IsFloating . 6�     5?      $	 NewspaperVariantOutline=�6&   $��Bottom=�6�   $
��10 4q�6�   $��0��6�   $��1��6�   ��6E   �� $
 txtRFC��$ BorderBrush�6�   �� 5@      -   5        $ txtRFC��5@      $��0��6&   $��1��66   $	��300��6C   $	 RFC��6O   $	��0 6q�6t    . 6�     5B      $	 
AccountTie=�6&   $��Bottom=�6|   $
��10 4q�6�   $��0��6�   $��2��6�   ��68   �� $
 txtRazonSocial��$ BorderBrush�6�   �� 5C      -   5        $ txtRazonSocial��5C      $��0��6.   $��2��6>   $	��300��6K   $ Nombre o Razon social��6W   $	��0 6q�6�    . 6�     5E      $	 RegisteredTrademark=�6&   $��Bottom=�6�   $
��10 4q�6�   $��0��6�   $��3��6�   ��6A   �� $
 txtNombreComercial��$ BorderBrush�6�   �� 5F      -   5        $ txtNombreComercial��5F      $��0��62   $��3��6B   $	��300��6O   $ Nombre comercial��6[   $	��0 6q�6�    . 6�     5H      $	 AccountCardDetailsOutline=�6&   $��Bottom=�6�   $
��10 4q�6�   $��1��6�   $��0��6�   ��6G   �� $
 txtCURP��$ BorderBrush�6�   �� 5I      -   5        $ txtCURP��5I      $��1��6'   $��0��67   $	��300��6D   $
 CURP��6P   $	��0 6q�6v    . 6�     5K      $	 Domain=�6&   $��Bottom=�6v   $
��10 4q�6�   $��1��6�   $��1��6�   ��64   �� $
 cmbDireccion��$ BorderBrush�6�   �� 5L      -	   5         ��Name$ cmbDireccion��5L      $��1��6-   $��1��6=   $	��300��6J   $  Elige una direccion fiscal��6V   $	��0 6q�6�    . .@�5M      �� 6!   5N      �� 5_      -
   5        $ 
btnGuardar��5_       �� 	IsDefault . ���#0069D9$��Guardar��6O   $��1��6a   $��6��6q   $	��100��6~   $��30��6�   $
��Left=�6�   $��170 10 15 0q�6�   ��6�   Z� 6�   �� 5`      -   5        $ btnCancelar��5`       . ���#5A6268$��Cancelar��6P   $��1��6c   $��6��6s   $	��100��6�   $��30��6�   $��Right=�6�   $��	0 10 15 0q�6�   ��6�   Z� 6�   5b      5c      5d      