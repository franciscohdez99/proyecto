   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	   '    !Line.VISTA.V_DialogHorarioTrabajo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  V_DialogHorarioTrabajo��5	   	   $	��455��5
   	   $	��800��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   $��0 0 0 0q�5   	   
������ .��5      � .+�5   
   � -   5        $��myGrids��5      ���	#FF1368BD � ColumnDefinitions 5      �� 5      $��* �6#   6/    � RowDefinitions 5      �� 5      $��50 �6    6.   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5      �� $$��Registro de horario de trabajo��6   ���#FFF$��14(�6S   $
��Bold"�6a   $��10 10 10 10q�6s   6�   5      �� 5      $ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5         ��Name$ 	btnCerrar��5      $��30��6,   $��30��67   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6C   $��0q�6t   $��5 5 5 5q�6�   
���  ����6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 WindowClose=�6.   $��Right=�6A   5       5!      5"      � 5#   
   -   5        $��myGrid��5#      $��0 50 0 0q�6   
�������$	��392��6F    5%      �� 5&      $��* �6#   �� 5'      $��* �6#    5*      �� 5+      $��50 �6    �� 5,      $��50 �6    �� 5-      $��50 �6    �� 5.      $��50 �6    �� 5/      $��50 �6    �� 50      $��50 �6    �� 51      $��50 �6    �� 52      $��50 �6    .+�55        $	 IdentificationCard=�6&   $��Bottom=�6�   $
��10 4q�6�   $��0��6�   $��1��6�   ��6@   �� 
 �� ElementName$
 txtIdHorarioTrabajo�� �� Path$ BorderBrush�6�   �� 56      -   5         ��Name$ txtIdHorarioTrabajo��56      $��0��63   $��1��6C   $	��300��6P   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID Horario de trabajo��6\   $	��0 6q�6�      
IsFloating . 6�     58      $	 	DateRange=�6&   $��Bottom=�6t   $
��10 4q�6�   $��0��6�   $��2��6�   ��67   �� $
 dtFecha��$ BorderBrush�6�   (  "System.Windows.Controls.DatePicker  5:      -   5          Name$ dtFecha��5:         SelectedDate$ 
2020-01-31X�6*   $��0��6D   $��2��6T   $	��300��6a   $ Fecha��6m   $	��0 6q�6�    . 6�     5<      $	 
Shop24Hour=�6&   $��Bottom=�6|   $
��10 4q�6�   $��0��6�   $��3��6�   ��68   �� $
 txtHoraEntrada��$ BorderBrush�6�   �� 5=      -   5        $ txtHoraEntrada��5=      $��0��6.   $��3��6>   $	��300��6K   $ Hora de entrada��6W   $	��0 6q�6�    . 6�     5?      $	 Store24Hour=�6&   $��Bottom=�6|   $
��10 4q�6�   $��1��6�   $��1��6�   ��69   �� $
 txtHoraSalida��$ BorderBrush�6�   �� 5@      -   5        $ txtHoraSalida��5@      $��1��6-   $��1��6=   $	��300��6J   $ Hora de salida��6V   $	��0 6q�6�    . 6�     5C      $	 	PersonAdd=�6&   $��Bottom=�6x   $
��10 4q�6�   $��1��6�   $��2��6�   ��67   �� $
 cmbPersonal��$ BorderBrush�6�   �� 5F      -   5         ��Name$ cmbPersonal��5F      $��1��6,   $��2��6<   $	��300��6I   $ Elige un personal��6U   $	��0 6q�6�    . .@�5G      �� 6!   5H      �� 5L      -	   5        $ 
btnGuardar��5L      ���#0069D9$��Guardar��6>   $��1��6P   $��6��6`   $	��100��6m   $��30��6y   $
��Left=�6�   $��170 10 15 0q�6�   ��6�   Z� 6�   �� 5M      -
   5        $ btnCancelar��5M      ���#5A6268$��Cancelar��6?   $��1��6R   $��6��6b   $	��100��6o   $��30��6{   $��Right=�6�   $��	0 10 15 0q�6�   ��6�   Z� 6�   5O      5P      5Q      