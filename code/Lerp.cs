using Sandbox;

public sealed class LerpSpawner : Component
{
	[Property] GameObject prefab {get;set;}

	protected override void OnStart()
	{
		base.OnStart();
		Spawn();
	}

	private async void Spawn()
	{
		prefab.Clone( Transform.Position + Vector3.Up * 100.0f );
		await GameTask.DelayRealtimeSeconds(2.0f);
		Spawn();
	}
}

public sealed class Lerp : Component
{
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		Transform.Position = Transform.Position + Vector3.Right * 300.0f * Time.Delta;
	}
}