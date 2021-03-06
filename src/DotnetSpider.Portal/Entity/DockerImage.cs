using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetSpider.Portal.Entity
{
	[Table("docker_image")]
	public class DockerImage
	{
		/// <summary>
		/// 主键
		/// </summary>
		[Column("id")]
		public int Id { get; set; }

		/// <summary>
		/// 仓储标识
		/// </summary>
		[Required]
		[Column("repository_id")]
		public int RepositoryId { get; set; }

		/// <summary>
		/// registry.cn-shanghai.aliyuncs.com/zlzforever/helloworld:20190409.22
		/// </summary>
		[StringLength(255)]
		[Required]
		[Column("image")]
		public string Image { get; set; }

		/// <summary>
		/// Creation time of this entity.
		/// </summary>
		[Required]
		[Column("creation_time")]
		public DateTime CreationTime { get; set; }
	}
}