   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	   $    Line.VISTA.VDialog_Organigrama   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  VDialog_Organigrama��5	   	   $	��455��5
   	   $	��800��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   $��0 0 0 0q�5   	   
������ .��5      � .+�5   
   � -   5        $��myGrids��5      ���	#FF1368BD � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��50 �6    6.   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��Registro de organigrama��6   ���#FFF$��14(�6L   $
��Bold"�6Z   $��10 10 10 10q�6l   6�   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	btnCerrar��5      $��30��6,   $��30��67   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6C   $��0q�6t   $��5 5 5 5q�6�   
���  ����6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowClose=�6.   $��Right=�6A   5       5!      5"      � 5#   
   -   5        $��myGrid��5#      $��0 50 0 0q�6   
�������$	��392��6F    5%      �� 5&      $��* �6#   �� 5'      $��* �6#    5*      �� 5+      $��50 �6    �� 5,      $��50 �6    �� 5-      $��50 �6    �� 5.      $��50 �6    �� 5/      $��50 �6    �� 50      $��50 �6    �� 51      $��50 �6    �� 52      $��50 �6    .+�55        $	 KeyAdd=�6&   $��Bottom=�6w   $
��10 4q�6�   $��0��6�   $��1��6�   ��64   �� 
 �� ElementName$
 txtIdSucursal�� �� Path$ BorderBrush�6�   �� 56      -   5         ��Name$ txtIdOrganigrama��56      $��0��60   $��1��6@   $	��300��6M   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID organigrama��6Y   $	��0 6q�6�      
IsFloating . 6�     59      $	 	PersonAdd=�6&   $��Bottom=�6x   $
��10 4q�6�   $��0��6�   $��2��6�   ��67   �� $
 cmbPersonal��$ BorderBrush�6�   �� 5<      -   5         ��Name$ cmbPersonal��5<      $��0��6,   $��2��6<   $	��300��6I   $ Elige un personal��6U   $	��0 6q�6�    . .@�5=      �� 6!   5>        5A      $	 Teaching=�6&   $��Bottom=�6u   $
��10 4q�6�   $��0��6�   $��3��6�   ��66   �� $
 	txtPuesto��$ BorderBrush�6�   �� 5B      -   5        $ 	txtPuesto��5B      $��0��6)   $��3��69   $	��300��6F   $ Puesto��6R   $	��0 6q�6z    . 6�     5I      $	 SignRealEstate=�6&   $��Bottom=�6z   $
��10 4q�6�   $��1��6�   $��1��6�   ��6<   �� $
 txtNivel��$ BorderBrush�6�   �� 5J      -   5        $ txtNivel��5J      $��1��6(   $��1��68   $	��300��6E   $ Nivel��6Q   $	��0 6q�6x    . 6�     5L      $	 Dependencies=�6&   $��Bottom=�6~   $
��10 4q�6�   $��1��6�   $��2��6�   ��6:   �� $
 txtDependencia��$ BorderBrush�6�   �� 5M      -   5        $ txtDependencia��5M      $��1��6.   $��2��6>   $	��300��6K   $ Dependencia��6W   $	��0 6q�6�    . 6�   �� 5O      -	   5        $ 
btnGuardar��5O      ���#0069D9$��Guardar��6>   $��1��6P   $��6��6`   $	��100��6m   $��30��6y   $
��Left=�6�   $��170 10 15 0q�6�   ��6�   Z� 6�   �� 5P      -
   5        $ btnCancelar��5P      ���#5A6268$��Cancelar��6?   $��1��6R   $��6��6b   $	��100��6o   $��30��6{   $��Right=�6�   $��	0 10 15 0q�6�   ��6�   Z� 6�   5R      5S      5T      