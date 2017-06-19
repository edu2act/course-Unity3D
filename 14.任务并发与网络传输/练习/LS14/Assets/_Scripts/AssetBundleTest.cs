using UnityEngine;
using System.Collections;
using UnityEditor;
public class AssetBundleTest : Editor {
	//每个资源文件均打包 
	[MenuItem("自定义编辑器/每个资源创建一个AssetBunldes文件")]
	static void CreateAssetBunldesSinglePackage(){
		BuildPipeline.BuildAssetBundles("Assets/_Prefabs", 
			BuildAssetBundleOptions.None,
			BuildTarget.StandaloneWindows);
	}
}
