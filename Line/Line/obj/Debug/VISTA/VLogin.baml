   M S B A M L   `   `   `  ����?  ;Line, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Line.VISTA
Line.VISTA  5   	       Line.VISTA.VLogin   5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Line.VISTA     5   	     � Title$  VLogin��5	   	   $	��500��5
   	   $	��350��5   	    � WindowStyle$
 None=�5   	   ���#FFF � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF0361B0��6#   � 5      $ 	#FFEAEAEC��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $��
36,0,34,92q�6H    �� RadiusY$ 10��6\   	 �� RadiusX$	 10��6i   
�������
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5    
   $��Bottom=�6   $��
35,0,35,44q�6*   $	��276��6>    � ColumnDefinitions 5!      �� 5"      $��4* �6#   �� 5#      $��3* �6#   �� 5$      $
��257* �6#   �� 5%      $	��17* �6#   .+�5'      �� $��Inicio de sessión��6   $��Center=�60   $	��Top=�6M   $��64,5,54.5,0q�6e   
�������$��18(�6�   $��2��6�   �� 5(      $��Center=�6   $��
9,50,15,72q�64   $	��154��6H   $��2��6U   $��2��6e   .+�5)      �� -   5         ��Name$ 
txtUsuario��5)      $	��0,5q�6.   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre de usuario��6;    %  !MaterialDesignFloatingHintTextBox#��[  6n   $��Champagne & Limousines)�6�   $��18(�6�   G� 5*      -   5         G�Name$ txtPass��5*      $	��0,5q�60   $ Contraseña��6=    ) %MaterialDesignFloatingHintPasswordBox#��[ 6i   $��Champagne & Limousines)�6�   $��18(�6�   52      �� 53      -   5         ��Name$ 	btnEntrar��53       �� 	IsDefault . $	��141��6Q   $��Center=�6t   $��Bottom=�6�   $��	131,0,1,0q�6�   $��Entrar��6�   $��2��6�   $��2��6�   ��6]   Z� 6�   �� 54      -   5        $ btnCancelar��54       . $	��131��6;   $��Center=�6^   $��Bottom=�6{   $��1,0,131.5,0q�6�   $��Cancelar��6�   
���  ��$��3��6�   ��6G   Z� 6�   55      �� 58   
   $
��1000��6   $	��100��6   $	��Top=�6*   $��30q�6B   59      5:      