   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	       Line.VISTA.V_Proyecto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
V_Proyecto��5	   	   $	��455��5
   	   $	��800��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��0 0 0 0q�5   	    � WindowStyle$
 None=�5   	   ���#FFF.��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   6,   �� 5      6!   �� 5      $��10 �6   6,    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��75 �6   6*   �� 5      $��75 �6   6*   �� 5      $��75 �6   6*   �� 5      6   .+�5!   
   �� -   5         ��Name$ lblGridColum0��5!      ���	#FF1368BD$��0q�6>   $��0��6J   $��0��6Z   ��6g   Z� 6�   �� 5"   
   -   5        $ lblGridColum1��5"      ���	#FF1368BD$��0q�6>   $��1��6J   $��0��6Z   ��6g   Z� 6�   �� 5#   
   -   5        $ lblGridColum2��5#      ���	#FF1368BD$��0q�6>   $��2��6J   $��0��6Z   ��6g   Z� 6�   �� 5%   
   -   5        $ 	lblTitulo��5%      $$��Lista de registro de proyectos��5&      ���#FFF
������ $��14(�5)      $
��Bold"�5*      $��5 5 5 5q�5+      $��
10 5 550 0q�5,      $��1��5-      $��0��5.      5/      �� 50   
   -   5         ��Name$ btnCloseWindow��50      $��X��51      $��1��52      $��0��53      $��Right=�54      
���  ��$��0 5 0 0q�57      $��0 0 0 0q�58      $��30��6#   $��30��59      ��56      Z� 5:      �� 5;   
   -   5         ��Name$ 	txtBuscar��5;      
�������$
��Left=�5=      $��1��5>      $��3��5?      $	��435��5@      $��30��5A      $��	10 40 0 0q�5B      $��5 -5 0 0q�5C      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 	Buscar...��5E      
   
IsFloating
 . ��5D      Z� .��5E   i   5F      �� 5G   
   -   5        $ btnNuevo��5G      $��Nuevo��5H      
��� � �$��Stretch=�5K      $��1��5L      $��3��5M      $	��100��5N      $��450 0 225 -40q�5O      ��5J      Z� 5P      �� 5Q   
   -   5        $ 	btnEditar��5Q      $��Editar��5R      
��� ���$��Stretch=�5U      $��1��5V      $��3��5W      $	��100��5X      $��450 0 10 -40q�5Y      ��5T      Z� 5Z      �� 5[   
   -	   5        $ btnEliminar��5[      $��Eliminar��5\      
���  ��$��Right=�5_      $��1��5`      $��3��5a      $	��100��5b      $��
0 0 10 -40q�5c      ��5^      Z� 5d      &   System.Windows.Controls.DataGrid  5f   
   -
   5          Name$ DgvPlantilla��5f      $��10 10 10 10q�6)      AutoGenerateColumns .  $��1��6r   $��4��6�   ��6>   ��    Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5h      -   5        txtIdProyecto��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5h   <   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   ��  �� Path$ 
idproyecto�  5i      -   5        
txtCliente��$ Nombre del cliente��5i   9    6U   �� $ 	idcliente�  5j      -   5        txtNombreProyecto��$ Nombre del proyecto��5j   @    6]   �� $ nombreproyecto�  5k      -   5        
txtEstatus��$ Estatus��5k   9    6J   �� $ estatus�  5l      -   5        txtWorkflow��$ Workflow��5l   :    6L   �� $ 
idworkflow�  5m      -   5        txtCategoria��$ 	Categoria��5m   ;    6N   �� $ idcategoria�5p      5q      5r      