   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	   !    Line.VISTA.VDialog_Eliminar   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  VDialog_Eliminar��5	   	   $	��300��6"   $	��400��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q   $��0 0 0 0q�6v    � WindowStyle$
 None=�6�   ���#FFF.��5
      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   6,   �� 5      6!   �� 5      $��10 �6   6,    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��75 �6   6*   �� 5      $��75 �6   6*   �� 5      $��75 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ lblGridColum0��5      ���	#FF1368BD$��0q�6>   $��0��6J   $��0��6Z   ��6g   Z� 6�   �� 5   
   -   5        $ lblGridColum1��5      ���	#FF1368BD$��0q�6>   $��1��6J   $��0��6Z   ��6g   Z� 6�   �� 5   
   -   5        $ lblGridColum2��5      ���	#FF1368BD$��0q�6>   $��2��6J   $��0��6Z   ��6g   Z� 6�   �� 5   
   -   5        $ 	lblTitulo��5      $��Confirmar eliminacion��5      ���#FFF
������ $��14(�5!      $
��Bold"�5"      $��5 5 5 5q�5#      $��	5 5 200 0q�5$      $��1��5%      $��0��5&      5'      �� 5(   
   -   5         ��Name$ btnCloseWindow��5(      $��X��5)      $��1��5*      $��0��5+      $��Right=�5,      
���  ��$��0 5 0 0q�5/      $��0 0 0 0q�50      $��30��6#   $��30��51      ��5.      Z� 52      �� 53   
   -   5         ��Name$ txtID��53      
�������$
��Left=�55      $��1��56      $��2��57      $	��140��58      $��30��59      $��	40 0 10 0q�5:      $��5 -5 0 0q�5;      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 ID��5=      
   
IsFloating
 . ��5<      Z� .��5=   b   5>      �� 5?   
   -   5        $ 	txtNombre��5?      
�������$��1��5A      $��2��5B      $	��140��5C      $��30��5D      $��200 -12 20 -10q�5E      $��5 -5 0 0q�5F      $	 Nombre��5H      
 . ��5G      Z� .��5H   f   5I      �� 5J   
   -   5        $ btnCancelar��5J      $��Cancelar��5K       �� IsCancel . 
�������$��Right=�5O      $��1��5P      $��3��5Q      $	��140��5R      $��40 0 30 -40q�5S      ��5N      Z� 5T      �� 5U   
   -	   5        $ btnEliminar��5U      $��Eliminar��5V      
���  ��$
��Left=�5Y      $��1��5Z      $��3��5[      $	��140��5\      $��40 0 10 -40q�5]      ��5X      Z� 5^      5_      5`      