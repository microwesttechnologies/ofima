export interface MenuItem {
    label?: string;
    icon?: string;
    command?(event: MenuItemCommandEvent): void;
    url?: string;
    items?: MenuItem[];
    expanded?: boolean;
    disabled?: boolean;
    visible?: boolean;
    target?: string;
    escape?: boolean;
    routerLinkActiveOptions?: any;
    separator?: boolean;
    badge?: string;
    tooltip?: string;
    tooltipPosition?: string;
    badgeStyleClass?: string;
    style?: { [klass: string]: any } | null | undefined;
    styleClass?: string;
    title?: string;
    id?: string;
    automationId?: any;
    tabindex?: string;
    routerLink?: any;
    queryParams?: { [k: string]: any };
    fragment?: string;
    preserveFragment?: boolean;
    skipLocationChange?: boolean;
    replaceUrl?: boolean;
    iconStyle?: { [klass: string]: any } | null | undefined;
    iconClass?: string;
    state?: { [k: string]: any };
    [key: string]: any;
}

export interface MenuItemCommandEvent {
    originalEvent?: Event;
    item?: MenuItem;
    index?: number;
}
