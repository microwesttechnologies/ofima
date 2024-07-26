export interface FinalMenu {
  id_finalmenu: number;
  name_finalmenu: string;
  id_submenu: number;
  submenu_menu?: SubMenu;
}

export interface SubMenu {
  id_submenu: number;
  name_submenu: string;
  id_subcategory: number;
  subcategory_menu?: SubCategory;
  finalmenu_menu?: FinalMenu[];
}

export interface SubCategory {
  id_subcategory: number;
  name_subcategory: string;
  id_category: number;
  category_menu?: Category;
  submenu_menu?: SubMenu[];
}

export interface Category {
  id_category: number;
  name_category: string;
  subcategory_menu?: SubCategory[];
}
