   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	   !    Line.VISTA.VDialog_Proyecto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  VDialog_Proyecto��5	   	   $	��455��5
   	   $	��800��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   $��0 0 0 0q�5   	   
������ .��5      � .+�5   
   � -   5        $��myGrids��5      ���	#FF1368BD � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��50 �6    6.   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5      �� $��Registro de proyectos��6   ���#FFF$��14(�6J   $
��Bold"�6X   $��10 10 10 10q�6j   6�   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	btnCerrar��5      $��30��6,   $��30��67   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6C   $��0q�6t   $��5 5 5 5q�6�   
���  ����6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowClose=�6.   $��Right=�6A   5       5!      5"      � 5#   
   -   5        $��myGrid��5#      $��0 50 0 0q�6   
�������$	��392��6F    5%      �� 5&      $��* �6#   �� 5'      $��* �6#    5*      �� 5+      $��50 �6    �� 5,      $��50 �6    �� 5-      $��50 �6    �� 5.      $��50 �6    �� 5/      $��50 �6    �� 50      $��50 �6    �� 51      $��50 �6    �� 52      $��50 �6    .+�55        $	 IdentificationCard=�6&   $��Bottom=�6�   $
��10 4q�6�   $��0��6�   $��0��6�   ��6@   �� 
 �� ElementName$
 txtIdProyecto�� �� Path$ BorderBrush�6�   �� 56      -   5         ��Name$ txtIdProyecto��56      $��0��6-   $��0��6=   $	��300��6J   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID Proyecto��6V   $	��0 6q�6�      
IsFloating . 6�     58      $	 PersonAlertOutline=�6&   $��Bottom=�6�   $
��10 4q�6�   $��0��6�   $��1��6�   ��6@   �� $
 
cmbCliente��$ BorderBrush�6�   �� 59      -   5         ��Name$ 
cmbCliente��59      $��0��6+   $��1��6;   $	��300��6H   $ Elige un cliente��6T   $	��0 6q�6�    . .@�5:      �� 6!   5;        5=      $	 Folder=�6&   $��Bottom=�6{   $
��10 4q�6�   $��0��6�   $��2��6�   ��64   �� $
 txtNombreProyecto��$ BorderBrush�6�   �� 5>      -   5        $ txtNombreProyecto��5>      $��0��61   $��2��6A   $	��300��6N   $ Nombre del proyecto��6Z   $	��0 6q�6�    . 6�     5@      $	 StateMachine=�6&   $��Bottom=�6z   $
��10 4q�6�   $��1��6�   $��0��6�   ��6:   �� $
 
txtEstatus��$ BorderBrush�6�   �� 5A      -   5        $ 
txtEstatus��5A      $��1��6*   $��0��6:   $	��300��6G   $ Estatus��6S   $	��0 6q�6|    . 6�     5C      $	 Workflow=�6&   $��Bottom=�6w   $
��10 4q�6�   $��1��6�   $��1��6�   ��66   �� $
 cmbWorkflow��$ BorderBrush�6�   �� 5D      -   5        $ cmbWorkflow��5D      $��1��6,   $��1��6<   $	��300��6I   $ Elige un flujo de trabajo��6U   $	��0 6q�6�    . .@�5E      �� 6!   5F        5H      $	 Category=�6&   $��Bottom=�6x   $
��10 4q�6�   $��1��6�   $��2��6�   ��66   �� $
 cmbCategoria��$ BorderBrush�6�   �� 5I      -	   5        $ cmbCategoria��5I      $��1��6-   $��2��6=   $	��300��6J   $ Elige una categoria��6V   $	��0 6q�6�    . .@�5J      �� 6!   5K      �� 5M      -
   5        $ 
btnGuardar��5M      ���#0069D9$��Guardar��6>   $��1��6P   $��6��6`   $	��100��6m   $��30��6y   $
��Left=�6�   $��170 10 15 0q�6�   ��6�   Z� 6�   �� 5N      -   5        $ btnCancelar��5N      ���#5A6268$��Cancelar��6?   $��1��6R   $��6��6b   $	��100��6o   $��30��6{   $��Right=�6�   $��	0 10 15 0q�6�   ��6�   Z� 6�   5P      5Q      5R      