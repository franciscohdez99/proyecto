   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	        Line.VISTA.VDialog_Cliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  VDialog_Cliente��5	   	   $	��455��5
   	   $	��800��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   ���	#FF1368BD.��5      � .+�5   
   � -   5        $��myGrids��5      ���	#FF1368BD � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��50 �6    6.   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��Registro de clientes��6   ���#FFF$��14(�6I   $
��Bold"�6W   $��10 10 10 10q�6i   6�   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	btnCerrar��5      $��30��6,   $��30��67   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6C   $��0q�6t   $��5 5 5 5q�6�   
���  ����6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowClose=�6.   $��Right=�6A   5      5       5!      � 5"   
   -   5        $��myGrid��5"      $��0 50 0 0q�6   
�������$	��392��6F    5$      �� 5%      $��* �6#   �� 5&      $��* �6#    5)      �� 5*      $��50 �6    �� 5+      $��50 �6    �� 5,      $��50 �6    �� 5-      $��50 �6    �� 5.      $��50 �6    �� 5/      $��50 �6    �� 50      $��50 �6    �� 51      $��50 �6    .+�58        $		 Key=�6&   $��Bottom=�6s   $
��10 4q�6�   $��0��6�   $��1��6�   ��61   �� 
 �� ElementName$
 txtIDCliente�� �� Path$ BorderBrush�6�   �� 59      -   5         ��Name$ txtIDCliente��59      $��0��6,   $��1��6<   $	��300��6I   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
ID Cliente��6U   $	��0 6q�6�      
IsFloating . 6�     5<      $	 Register=�6&   $��Bottom=�6|   $
��10 4q�6�   $��0��6�   $��2��6�   ��66   �� $
 txtNombreCliente��$ BorderBrush�6�   �� 5=      -   5        $ txtNombreCliente��5=      $��0��60   $��2��6@   $	��300��6M   $ Nombre del cliente��6Y   $	��0 6q�6�    . 6�     5?      $	 Database=�6&   $��Bottom=�6w   $
��10 4q�6�   $��0��6�   $��3��6�   ��66   �� $
 txtApaterno��$ BorderBrush�6�   �� 5@      -   5        $ txtApaterno��5@      $��0��6+   $��3��6;   $	��300��6H   $ Apellido paterno��6T   $	��0 6q�6�    . 6�     5B      $	 CashRegister=�6&   $��Bottom=�6{   $
��10 4q�6�   $��1��6�   $��1��6�   ��6:   �� $
 txtAmaterno��$ BorderBrush�6�   �� 5C      -   5        $ txtAmaterno��5C      $��1��6+   $��1��6;   $	��300��6H   $ Apellido materno��6T   $	��0 6q�6�    . 6�     5E      $	 Phone=�6&   $��Bottom=�6v   $
��10 4q�6�   $��1��6�   $��2��6�   ��63   �� $
 txtNoTelefono��$ BorderBrush�6�   �� 5F      -   5        $ txtNoTelefono��5F      $��1��6-   $��2��6=   $	��300��6J   $ Número de telefono��6V   $	��0 6q�6�    . 6�     5H      $	 Email=�6&   $��Bottom=�6q   $
��10 4q�6�   $��1��6�   $��3��6�   ��63   �� $
 txtEmail��$ BorderBrush�6�   �� 5I      -	   5        $ txtEmail��5I      $��1��6(   $��3��68   $	��300��6E   $ Correo electronico��6Q   $	��0 6q�6�    . 6�   �� 5L      -
   5        $ 
btnGuardar��5L       �� 	IsDefault . ���#0069D9$��Guardar��6O   $��1��6a   $��6��6q   $	��100��6~   $��30��6�   $
��Left=�6�   $��170 10 15 0q�6�   ��6�   Z� 6�   �� 5M      -   5        $ btnCancelar��5M       . ���#5A6268$��Cancelar��6P   $��1��6c   $��6��6s   $	��100��6�   $��30��6�   $��Right=�6�   $��	0 10 15 0q�6�   ��6�   Z� 6�   5O      5P      5Q      