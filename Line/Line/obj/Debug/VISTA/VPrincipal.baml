   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	       Line.VISTA.VPrincipal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
VPrincipal��5	   	   $	��600��6   $
��1080��6)    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � WindowStyle$
 None=�6q   
�������
������� � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63   6@     5      $ 0:0:0.5��6'   $	 200Q�69   6G   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63   6A     5      $ 0:0:0.5��6'   $ 60Q�69   6F   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ BtnOpenMenu��66   .[�5      �� #��[  6   6G   5      :� 5    
   $
 ButtonBase.Click��6   $ BtnCloseMenu��66   .[�5!      �� #��[ 6   6H   5"      .��5'      �  � ForceCursor . 
�������.+�5)   
   � $��60��6   $	��Top=�6   ���	#FF1368BD.+�5*      �� $ ��Sistema de Automatización��6   $��Center=�69   $��Center=�6V   $��22(�6q   6�   �� 5+      -   5         ��Name$ BtnViewOpciones��5+      $��Center=�62    �� Orientation$ 
Horizontal=�6M   $��Right=�6f   .+�5,      �� $��Configuración��6   $��Center=�61   $��18(�6L   6\   '  !MaterialDesignThemes.Wpf.PopupBox  5-      $��Right=�6*   $��10q�6F      PlacementMode$ BottomAndAlignRightEdges=�6R      	StaysOpen .     PopupContent. 5.      �� $	��150��6!   .+�5/      �� -   5         ��Name$ 	BtnCuenta��5/   !   $��Cuenta��64   6G   �� 50      -   5        $ 	BtnAjuste��50   !   $��Ajustes��64   6H   �� 51      -   5        $ BtnAyuda��51   !   $��Ayuda ��63   6F   �� 52      6&   �� 53      -   5        $ 	BtnLogout��53   !   $��Logout��64   6G   54      55      56      57      � 58   
   $	��450��6   $	��910��6   $��Center=�6(   
������ .+�5<      �� -   5         ��Name$ pnContenedor��5<      $��0,0,0,1q�6+   $	��450��6<   $	��900��6I   $��Center=�6V   
�������$��Center=�6�   5>      5B      � 5D   
   -   5         �Name$ GridMenu��5D      $��60��6!   $
��left=�6,   ���	#FF1B3861.+�5E      �� .+�5F      � $	��150��6   
�������.+�5G      �� -   5        $ BtnCloseMenu��5G      $��60��63   $��60��6>   $	��Top=�6w   $��Right=�6�   $y�	Collapsed=�6�   ��6J   Z� ��6`   Z� .��5H      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF1B3861   Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   6s   5I      �� 5K      -	   5        $ BtnOpenMenu��5K      $��60��62   $��60��6=   $	��Top=�6v   $��Right=�6�   ��6I   Z� ��6_   Z� .��5L        ���	#FF1B3861$
 Menu=�6I   $��25��6U   $��25��6`   6n   5M      5N      �� 5O      $��Disabled=�6   ���	#FF1368BD.@�5R      �� $��60��6#   .��5S      �� $ 
Horizontal=�6%   .+�5T        ���#FFFFFF$ ViewDashboard=�6K   $��25��6`   $��25��6k   $��10q�6w   $��Center=�6�   6�   �� 5U      ���#FFF$
��Home��6:   $��Center=�6F   $��20 10q�6a   6r   5V      5W      �� 5Y      -
   5         ��Name$ BtnViewEmpresa��5Y   /   $��60��6#   .��5Z      �� $ 
Horizontal=�6%   .+�5[        ���#FFF$ Business=�6H   $��25��6X   $��25��6c   $��10q�6o   $��Center=�6{   6�   �� 5\      ���#FFF$��Gestion de empresas��6:   $��Center=�6U   $��20 10q�6p   6�   5]      5^      �� 5`      -   5        $ BtnViewSucursal��5`   /   $��60��6#   .��5a      �� $ 
Horizontal=�6%   .+�5b        ���#FFF$ HumbleBundle=�6H   $��25��6\   $��25��6g   $��10q�6s   $��Center=�6   6�   �� 5c      ���#FFF$��Gestion de sucursales��6:   $��Center=�6W   $��20 10q�6r   �� 6�   -   5        $ BtnOpenSucursal��5c   �   $
��Left=�6�   6�   6�   5d      5e      �� 5g      $��60��6#   .��5h      �� $ 
Horizontal=�6%   .+�5i        ���#FFF$ UserAdd=�6H   $��25��6W   $��25��6b   $��10q�6n   $��Center=�6z   6�   �� 5j      ���#FFF$��Gestion de personal��6:   $��Center=�6U   $��20 10q�6p   6�   5k      5l      �� 5n      $��60��6#   .��5o      �� $ 
Horizontal=�6%   .+�5p        ���#FFF$ ViewDashboard=�6H   $��25��6]   $��25��6h   $��10q�6t   $��Center=�6�   6�   �� 5q      ���#FFF$��Gestion de p-s��6:   $��Center=�6P   $��20 10q�6k   6|   5r      5s      5t      5u      5v      5w      5x      