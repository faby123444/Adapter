using System;

namespace Adapter
{
	public class MotorElectricoAdapter : Motor
	{
		private MotorElectrico motorElectrico;

		public MotorElectricoAdapter()
		{
			motorElectrico = new MotorElectrico();
		}

		public override string Acelerar()
		{
			return motorElectrico.Mover();
		}

		public override string Arrancar()
		{
			return motorElectrico.Conectar();
			return motorElectrico.Activar();
		}

		public override string CargarCombustible()
		{
			return motorElectrico.Enchufar();
		}

		public override string Detener()
		{
			return motorElectrico.Parar();
			return motorElectrico.Desactivar();
			return motorElectrico.Desconectar();
		}
	}
}

