   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	   .    (Line.VISTA.VDialog_AsignPersonalProyecto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$#  VDialog_AsignPersonalProyecto��5	   	   $	��455��6/   $	��800��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   $��0 0 0 0q�5   	   
������ .��5      � .+�5   
   � -   5        $��myGrids��5      ���	#FF1368BD � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��50 �6    6.   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5      �� $9��3Registro de asignación de responsables a proyectos��6   ���#FFF$��14(�6g   $
��Bold"�6u   $��10 10 10 10q�6�   6�   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	btnCerrar��5      $��30��6,   $��30��67   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6C   $��0q�6t   $��5 5 5 5q�6�   
���  ����6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowClose=�6.   $��Right=�6A   5      5       5!      � 5"   
   -   5        $��myGrid��5"      $��0 50 0 0q�6   
�������$	��392��6F    5$      �� 5%      $��* �6#   �� 5&      $��* �6#    5)      �� 5*      $��50 �6    �� 5+      $��50 �6    �� 5,      $��50 �6    �� 5-      $��50 �6    �� 5.      $��50 �6    �� 5/      $��50 �6    �� 50      $��50 �6    �� 51      $��50 �6    .+�54        $	 KeyAdd=�6&   $��Bottom=�6t   $
��10 4q�6�   $��0��6�   $��1��6�   ��64   �� 
 �� ElementName$
 
txtIdAsign�� �� Path$ BorderBrush�6�   �� 55      -   5         ��Name$ 
txtIdAsign��55      $��0��6*   $��1��6:   $	��300��6G   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID Asignación��6S   $	��0 6q�6�      
IsFloating . 6�     58      $	 Folders=�6&   $��Bottom=�6v   $
��10 4q�6�   $��0��6�   $��2��6�   ��65   �� $
 cmbProyecto��$ BorderBrush�6�   �� 5;      -   5         ��Name$ cmbProyecto��5;      $��0��6,   $��2��6<   $	��300��6I   $ Elige un proyecto��6U   $	��0 6q�6�    . .@�5<      �� 6!   5=        5@      $	 StateMachine=�6&   $��Bottom=�6z   $
��10 4q�6�   $��1��6�   $��1��6�   ��6:   �� $
 
txtEstatus��$ BorderBrush�6�   �� 5A      -   5        $ 
txtEstatus��5A      $��1��6*   $��1��6:   $	��300��6G   $ Estatus��6S   $	��0 6q�6|    . 6�     5C      $	 Person=�6&   $��Bottom=�6u   $
��10 4q�6�   $��1��6�   $��2��6�   ��64   �� $
 cmbPersonal��$ BorderBrush�6�   �� 5F      -   5        $ cmbPersonal��5F      $��1��6,   $��2��6<   $	��300��6I   $ Elige un responsable��6U   $	��0 6q�6�    . .@�5G      �� 6!   5H      �� 5I      -   5        $ 
btnGuardar��5I      ���#0069D9$��Guardar��6>   $��1��6P   $��6��6`   $	��100��6m   $��30��6y   $
��Left=�6�   $��170 10 15 0q�6�   ��6�   Z� 6�   �� 5J      -	   5        $ btnCancelar��5J      ���#5A6268$��Cancelar��6?   $��1��6R   $��6��6b   $	��100��6o   $��30��6{   $��Right=�6�   $��	0 10 15 0q�6�   ��6�   Z� 6�   5L      5M      5N      